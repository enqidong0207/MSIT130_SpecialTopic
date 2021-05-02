using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSIT130_SpecialTopic
{
    public partial class frm_Backend_Workouts : Form
    {
        HealthManagementEntities dbContext = new HealthManagementEntities();
        public frm_Backend_Workouts()
        {
            InitializeComponent();
        }

        #region Shared Method
        private void LoadWCToCmbBox(BindingSource bs, params ComboBox[] cmbs)
        {
            if (bs.Count > 0)
            {
                for (int i = 0; i < cmbs.Length; i++)
                {
                    cmbs[i].DataSource = this.bsWC;
                    cmbs[i].DisplayMember = "Name";
                    cmbs[i].ValueMember = "ID";
                } 
            }
            else
            {
                for (int i = 0; i < cmbs.Length; i++)
                {
                    cmbs[i].DataSource = null;
                }
            }

        }

        private void LoadALToCmbBox(params ComboBox[] cmbs)
        {

            for (int i = 0; i < cmbs.Length; i++)
            {
                cmbs[i].DataSource = dbContext.ActivityLevels.OrderBy(al => al.ID).ToList();
                cmbs[i].DisplayMember = "Description";
                cmbs[i].ValueMember = "ID";

            }

        }

        private void LoadWToCmbBox(BindingSource bs, params ComboBox[] cmbs)
        {
            if (bs.Count > 0)
            {
                for (int i = 0; i < cmbs.Length; i++)
                {
                    cmbs[i].DataSource = this.bsW;
                    cmbs[i].DisplayMember = "Name";
                    cmbs[i].ValueMember = "ID";

                }
            }
            else
            {
                for (int i = 0; i < cmbs.Length; i++)
                {
                    cmbs[i].DataSource = null;
                }
            }

        }

        private bool TestTxtBoxIsEmpty(List<Label> lbls, params KeyValuePair<Label, TextBox>[] pairs)
        {
            bool b = true;

            for (int i = 0; i < pairs.Length; i++)
            {
                if (pairs[i].Value.Text == "")
                {
                    if (lbls[i].Text != "")
                    {
                        lbls[i].Text += "\n";
                    }
                    lbls[i].Text += $"請輸入{pairs[i].Key.Text}";
                    b = false;
                }
                else
                {
                    lbls[i].Text = "";
                }
            }

            return b;
        }

        private bool TestTxtBoxIsDouble(List<Label> lbls, params KeyValuePair<Label, TextBox>[] pairs)
        {
            bool b = true;

            for (int i = 0; i < pairs.Length; i++)
            {
                if (!double.TryParse(pairs[i].Value.Text, out double f))
                {
                    if (lbls[i].Text != "")
                    {
                        lbls[i].Text += "\n";
                    }
                    lbls[i].Text += $"請在{pairs[i].Key.Text}欄位輸入數字";
                    b = false;
                }
                else
                {
                    lbls[i].Text = "";
                }
            }

            return b;
        }

        private void ClearLabels(params Label[] lbls)
        {
            for (int i = 0; i < lbls.Length; i++)
            {
                lbls[i].Text = "";
            }
        }
        
        private void SetDataGridView<T>(DataGridView dgv, params string[] colsToHide)
        {
            List<string> navCols = new List<string>();

            var workspace = ((IObjectContextAdapter)dbContext).ObjectContext.MetadataWorkspace;
            var itemCollection = (ObjectItemCollection)(workspace.GetItemCollection(DataSpace.OSpace));
            var entityType = itemCollection.OfType<EntityType>().Single(e => itemCollection.GetClrType(e) == typeof(T));
            foreach (var navigationProperty in entityType.NavigationProperties)
            {
                navCols.Add(navigationProperty.Name);
            }


            List<string> collist = new List<string>();

            foreach (var propertyInfo in typeof(T).GetProperties())
            {
                if (!(propertyInfo.Name == "ID") && !(propertyInfo.Name == "Name"))
                {
                    if (colsToHide.Contains(propertyInfo.Name))
                    {
                        dgv.Columns[propertyInfo.Name].Visible = false;
                    }
                    else if (navCols.Contains(propertyInfo.Name))
                    {
                        dgv.Columns[propertyInfo.Name].Visible = false;
                    }
                    else
                    {
                        collist.Add(propertyInfo.Name);
                    }
                }
            }

            if (!dgv.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                btnCol.Name = "Delete";
                btnCol.Text = "刪除";
                btnCol.UseColumnTextForButtonValue = true;
                dgv.Columns.Add(btnCol);
            }

            collist.Sort();
            collist.Insert(0, "ID");
            collist.Insert(1, "Name");
            collist.Add("Delete");

            for (int i = 0; i < collist.Count; i++)
            {
                dgv.Columns[collist[i]].DisplayIndex = i;
            }

            
        }

        private void RejectChanges()
        {
            foreach (var entry in dbContext.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                    case EntityState.Deleted:
                        entry.State = EntityState.Modified; //Revert changes made to deleted entity.
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                }
            }
        }

        private void SetDataBinds()
        {
            this.cmbEditWC_Name.DataBindings.Add("SelectedValue", this.bsWC, "ID");

            this.cmbAddW_WC.DataBindings.Add("SelectedValue", this.bsW, "WorkoutCategoryID");
            this.cmbEditW_WC.DataBindings.Add("SelectedValue", this.bsW, "WorkoutCategoryID");

            this.cmbAddW_AL.DataBindings.Add("SelectedValue", this.bsW, "ActivityLevelID");
            this.cmbEditW_AL.DataBindings.Add("SelectedValue", this.bsW, "ActivityLevelID");

            this.cmbEditW_Name.DataBindings.Add("SelectedValue", this.bsW, "ID");

            this.txtEditW_Cal.DataBindings.Add("Text", this.bsW, "Calories");
        }
        #endregion

        private void frm_Backend_Workouts_Load(object sender, EventArgs e)
        {

            this.dgvWC.DataSource = this.bsWC;
            this.bsWC.DataSource = dbContext.WorkoutCategories.OrderBy(r => r.ID).ToList();
            
            this.dgvW.DataSource = this.bsW;
            this.bsW.DataSource = dbContext.Workouts.OrderBy(r => r.ID).ToList();

            SetDataGridView<WorkoutCategory>(this.dgvWC);
            SetDataGridView<Workout>(this.dgvW, "ActivityLevelID", "WorkoutCategoryID");

            LoadWCToCmbBox(this.bsWC, this.cmbEditWC_Name);
            LoadWCToCmbBox(this.bsWC, this.cmbAddW_WC, this.cmbEditW_WC);
            LoadWToCmbBox(this.bsW, this.cmbEditW_Name);
            LoadALToCmbBox(this.cmbAddW_AL, this.cmbEditW_AL);

            SetDataBinds();
        }

        #region WorkoutCategories
        private void btnAddWC_Click(object sender, EventArgs e)
        {
            List<Label> lbls = new List<Label>();
            lbls.Add(this.lblAddWC_Test);

            ClearLabels(lbls.ToArray());

            bool test = TestTxtBoxIsEmpty(lbls, 
                new KeyValuePair<Label, TextBox>(this.lblAddWC_Name, this.txtAddWC_Name)); ;

            if (!test)
            {
                return;
            }

            try
            {
                WorkoutCategory wc = new WorkoutCategory();
                wc.Name = this.txtAddWC_Name.Text;
                dbContext.WorkoutCategories.Add(wc);
                dbContext.SaveChanges();

                MessageBox.Show("新增運動類別成功");

                this.bsWC.Add(wc);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                RejectChanges();
            }
        }

        private void btnEditWC_Click(object sender, EventArgs e)
        {
            List<Label> lbls = new List<Label>();
            lbls.Add(this.lblEditWC_Test);

            ClearLabels(lbls.ToArray());

            bool test = TestTxtBoxIsEmpty(lbls,
                new KeyValuePair<Label, TextBox>(this.lblEditWC, this.txtEditWC_Name)); ;

            if (!test)
            {
                return;
            }

            try
            {
                WorkoutCategory wc = dbContext.WorkoutCategories
                    .Where(r => r.ID == (int)this.cmbEditWC_Name.SelectedValue).FirstOrDefault();
                wc.Name = this.txtEditWC_Name.Text;
                dbContext.SaveChanges();

                MessageBox.Show("修改運動類別成功");

                this.bsWC.ResetCurrentItem();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                RejectChanges();
            }
        }

        private void dgvWC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == dgv.Columns["Delete"].Index
                && MessageBox.Show("是否刪除此列？", "刪除", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int wcID = (int)dgv.Rows[e.RowIndex].Cells["ID"].Value;
                    var wc = dbContext.WorkoutCategories.Where(r => r.ID == wcID).FirstOrDefault();
                    dbContext.WorkoutCategories.Remove(wc);
                    dbContext.SaveChanges();

                    MessageBox.Show("刪除運動類型成功");

                    this.bsWC.Remove(wc);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    RejectChanges();
                }
            }
        }
        #endregion

        #region Workouts
        private void btnAddW_Click(object sender, EventArgs e)
        {
            List<Label> lbls = new List<Label>();
            lbls.Add(this.lblAddW_Name_Test);
            lbls.Add(this.lblAddW_Cal_Test);

            ClearLabels(lbls.ToArray());

            bool test = TestTxtBoxIsEmpty(lbls,
                new KeyValuePair<Label, TextBox>(this.lblAddW_Name, this.txtAddW_Name),
                new KeyValuePair<Label, TextBox>(this.lblAddW_Cal, this.txtAddW_Cal)
            );

            lbls.Clear();
            lbls.Add(this.lblAddW_Cal_Test);

            test &= TestTxtBoxIsDouble(lbls,
                new KeyValuePair<Label, TextBox>(this.lblAddW_Cal, this.txtAddW_Cal)
            );

            if (!test)
            {
                return;
            }

            try
            {
                Workout w = new Workout();
                w.Name = this.txtAddW_Name.Text;
                w.Calories = double.Parse(this.txtAddW_Cal.Text);
                w.WorkoutCategoryID = (int)this.cmbAddW_WC.SelectedValue;
                w.ActivityLevelID = (int)this.cmbAddW_AL.SelectedValue;

                dbContext.Workouts.Add(w);
                dbContext.SaveChanges();

                MessageBox.Show("新增運動成功");

                this.bsW.Add(w);
                this.dgvW.Columns["Delete"].DisplayIndex = this.dgvW.Columns.Count - 1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                RejectChanges();
            }
        }

        private void btnEditW_Click(object sender, EventArgs e)
        {
            List<Label> lbls = new List<Label>();
            lbls.Add(this.lblEditW_Name_Test);
            lbls.Add(this.lblEditW_Cal_Test);

            ClearLabels(lbls.ToArray());

            bool test = TestTxtBoxIsEmpty(lbls,
                new KeyValuePair<Label, TextBox>(this.lblEditW_Name, this.txtEditW_Name),
                new KeyValuePair<Label, TextBox>(this.lblEditW_Cal, this.txtEditW_Cal)
            );

            lbls.Clear();
            lbls.Add(this.lblEditW_Cal_Test);

            test &= TestTxtBoxIsDouble(lbls,
                new KeyValuePair<Label, TextBox>(this.lblEditW_Cal, this.txtEditW_Cal)
            );

            if (!test)
            {
                return;
            }

            try
            {
                Workout w = dbContext.Workouts.Where(r => r.ID == (int)this.cmbEditW_Name.SelectedValue).FirstOrDefault();
                w.Name = this.txtEditW_Name.Text;
                w.Calories = double.Parse(this.txtEditW_Cal.Text);
                w.WorkoutCategoryID = (int)this.cmbEditW_WC.SelectedValue;
                w.ActivityLevelID = (int)this.cmbEditW_AL.SelectedValue;

                dbContext.SaveChanges();

                MessageBox.Show("修改運動成功");

                this.bsW.ResetCurrentItem();
                this.dgvW.Columns["Delete"].DisplayIndex = this.dgvW.Columns.Count - 1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                RejectChanges();
            }
        }

        

        private void dgvW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == dgv.Columns["Delete"].Index
                && MessageBox.Show("是否刪除此列？", "刪除", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int wID = (int)dgv.Rows[e.RowIndex].Cells["ID"].Value;
                    int wCID = (int)dgv.Rows[e.RowIndex].Cells["WorkoutCategoryID"].Value;
                    int wALID = (int)dgv.Rows[e.RowIndex].Cells["ActivityLevelID"].Value;

                    var w = dbContext.Workouts.Where(r => r.ID == wID).FirstOrDefault();
                    dbContext.Workouts.Remove(w);
                    dbContext.SaveChanges();

                    MessageBox.Show("刪除運動成功");

                    this.bsW.Remove(w);
                    this.dgvW.Columns["Delete"].DisplayIndex = this.dgvW.Columns.Count - 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    RejectChanges();
                }
            }
        }
        #endregion

        #region BindingSource
        private void bsWC_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (this.bsWC.Count == 0)
            {
                LoadWCToCmbBox(this.bsWC, this.cmbEditWC_Name);
                LoadWCToCmbBox(this.bsWC, this.cmbAddW_WC, this.cmbEditW_WC);
            }
            else if (this.bsWC.Count == 1 && e.ListChangedType == ListChangedType.ItemAdded)
            {
                LoadWCToCmbBox(this.bsWC, this.cmbEditWC_Name);
                LoadWCToCmbBox(this.bsWC, this.cmbAddW_WC, this.cmbEditW_WC);
            }
            else if (e.ListChangedType == ListChangedType.ItemAdded)
            {
                this.bsWC.Position = e.NewIndex;
            }
        }

        private void bsW_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (this.bsW.Count == 0 && e.ListChangedType == ListChangedType.ItemDeleted)
            {
                LoadWToCmbBox(this.bsW, this.cmbEditW_Name);
                this.cmbAddW_WC.SelectedIndex = 0;
                this.cmbAddW_AL.SelectedIndex = 0;
                this.cmbEditW_WC.SelectedIndex = 0;
                this.cmbEditW_AL.SelectedIndex = 0;
            }
            else if (this.bsW.Count == 0)
            {
                LoadWToCmbBox(this.bsW, this.cmbEditW_Name);
            }
            else if (this.bsW.Count == 1 && e.ListChangedType == ListChangedType.ItemAdded)
            {
                LoadWToCmbBox(this.bsW, this.cmbEditW_Name);
            }
            else if(e.ListChangedType == ListChangedType.ItemAdded)
            {
                this.bsW.Position = e.NewIndex;
            }
        }
        #endregion

        #region Label Events
        private void label8_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.Red;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.Black;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.txtEditWC_Name.Text = this.cmbEditWC_Name.Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.txtEditW_Name.Text = this.cmbEditW_Name.Text;
        }
        #endregion

    }

    #region partial class test
    public partial class Workout
    {
        //[Column(Order = 13)]
        public string ActivityLevelDescription
        {
            get
            {
                return ActivityLevel.Description;
            }
        }

        //[Column(Order = 4)]
        public string WorkoutCategoryName
        {
            get
            {
                return WorkoutCategory.Name;
            }
        }
    }
    #endregion
}
