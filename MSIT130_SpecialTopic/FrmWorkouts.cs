using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class FrmWorkouts : Form
    {
        HealthManagementEntities dbContext = new HealthManagementEntities();
        public FrmWorkouts()
        {
            InitializeComponent();
            //dbContext.Entry(dbContext.Workouts.FirstOrDefault()).Reference(r => r.WorkoutCategory).Load();
        }

        #region Shared Method
       
        private void LoadCmbBox(BindingSource bs, string DisplayMember, string ValueMember, params ComboBox[] cmbs)
        {
            if (bs.Count > 0)
            {
                for (int i = 0; i < cmbs.Length; i++)
                {
                    cmbs[i].DataSource = bs;
                    cmbs[i].DisplayMember = DisplayMember;
                    cmbs[i].ValueMember = ValueMember;

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
                dgv.Columns[collist[i]].ReadOnly = true;
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
            this.txtEditWC_Name_Old.DataBindings.Add("Text", this.bsWC, "Name");

            this.cmbAddW_WC.DataBindings.Add("SelectedValue", this.bsW, "WorkoutCategoryID");
            this.cmbEditW_WC.DataBindings.Add("SelectedValue", this.bsW, "WorkoutCategoryID");

            this.cmbAddW_AL.DataBindings.Add("SelectedValue", this.bsW, "ActivityLevelID");
            this.cmbEditW_AL.DataBindings.Add("SelectedValue", this.bsW, "ActivityLevelID");

            this.txtEditW_Name_Old.DataBindings.Add("Text", this.bsW, "Name");

            this.txtEditW_Cal.DataBindings.Add("Text", this.bsW, "Calories");
        }

        private void SetSearchCmbBox()
        {
            var q1 = this.dbContext.WorkoutCategories.OrderBy(r => r.ID)
                .Select(r => new { Text = r.Name, Value = r.ID });

            var list1 = q1.ToList();
            list1.Insert(0, new { Text = "全部類型", Value = -1 });
            this.cmbSearchW_WC.DisplayMember = "Text";
            this.cmbSearchW_WC.ValueMember = "Value";
            this.cmbSearchW_WC.DataSource = list1;
            this.cmbSearchW_WC.SelectedValue = -1;

            var q2 = this.dbContext.ActivityLevels.OrderBy(r => r.ID)
                .Select(r => new { Text = r.Description, Value = r.ID });

            var list2 = q2.ToList();
            list2.Insert(0, new { Text = "全部強度", Value = -1 });
            this.cmbSearchW_AL.DisplayMember = "Text";
            this.cmbSearchW_AL.ValueMember = "Value";
            this.cmbSearchW_AL.DataSource = list2;
            this.cmbSearchW_AL.SelectedValue = -1;

        }
        #endregion

        #region Form Load Event
        private void FrmWorkouts_Load(object sender, EventArgs e)
        {

            this.dgvWC.DataSource = this.bsWC;
            this.bsWC.DataSource = dbContext.WorkoutCategories.OrderBy(r => r.ID).ToList();

            this.dgvW.DataSource = this.bsW;
            this.bsW.DataSource = dbContext.Workouts.OrderBy(r => r.ID).ToList();

            this.bsAL.DataSource = dbContext.ActivityLevels.OrderBy(r => r.ID).ToList();

            SetDataGridView<WorkoutCategory>(this.dgvWC);
            SetDataGridView<Workout>(this.dgvW, "ActivityLevelID", "WorkoutCategoryID");

            LoadCmbBox(this.bsWC, "Name", "ID", this.cmbAddW_WC, this.cmbEditW_WC);
            LoadCmbBox(this.bsAL, "Description", "ID", this.cmbAddW_AL, this.cmbEditW_AL);

            SetSearchCmbBox();

            SetDataBinds();

            this.lblAddWC_Test.Text = "";
            this.lblEditWC_Test.Text = "";
            this.lblAddW_Name_Test.Text = "";
            this.lblAddW_Cal_Test.Text = "";
            this.lblEditW_Name_Test.Text = "";
            this.lblSearchW_Cal_Test.Text = "";
        }
        #endregion

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
                    .Where(r => r.ID == ((WorkoutCategory)this.bsWC.Current).ID).FirstOrDefault();
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
                && MessageBox.Show($"是否刪除此列[{dgv.Rows[e.RowIndex].Cells["Name"].Value}]？", "刪除", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

        private void btnSearchWC_Click(object sender, EventArgs e)
        {
            if (this.txtSearchWC_Name.Text == "")
            {
                this.bsWC.DataSource = this.dbContext.WorkoutCategories
                    .OrderBy(r => r.ID).ToList();
            }
            else
            {
                this.bsWC.DataSource = this.dbContext.WorkoutCategories
                    .Where(r => r.Name.Contains(this.txtSearchWC_Name.Text))
                    .OrderBy(r => r.ID).ToList();
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

            ClearLabels(lbls.ToArray());

            bool test = TestTxtBoxIsEmpty(lbls,
                new KeyValuePair<Label, TextBox>(this.lblEditW_Name, this.txtEditW_Name)
            );


            if (!test)
            {
                return;
            }

            try
            {
                Workout w = dbContext.Workouts.Where(r => r.ID == ((Workout)this.bsW.Current).ID).FirstOrDefault();
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
                && MessageBox.Show($"是否刪除此列[{dgv.Rows[e.RowIndex].Cells["Name"].Value}]？", "刪除", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

        private void btnSearchW_Click(object sender, EventArgs e)
        {
            bool test1 = true, test2 = true;
            if (this.txtSearchW_Cal1.Text != "")
            {
                List<Label> lbls = new List<Label>();

                lbls.Add(this.lblSearchW_Cal_Test);
                lbls.Add(this.lblSearchW_Cal_Test);

                ClearLabels(lbls.ToArray());

                test1 = TestTxtBoxIsDouble(lbls,
                    new KeyValuePair<Label, TextBox>(this.lblSearchW_Cal, this.txtSearchW_Cal1)
                );
            }

            if (this.txtSearchW_Cal2.Text != "")
            {
                List<Label> lbls = new List<Label>();

                lbls.Add(this.lblSearchW_Cal_Test);
                lbls.Add(this.lblSearchW_Cal_Test);

                ClearLabels(lbls.ToArray());

                test2 = TestTxtBoxIsDouble(lbls,
                    new KeyValuePair<Label, TextBox>(this.lblSearchW_Cal, this.txtSearchW_Cal2)
                );
            }

            if (!test1 || !test2)
            {
                return;
            }

            this.bsW.DataSource = this.dbContext.Workouts.AsEnumerable().Where(r =>
            {
                bool flag = true;
                String name = "";
                double cal1 = 0d;
                double cal2 = 0d;
                int wcID = 0;
                int alID = 0;

                if (this.txtSearchW_Name.Text == "")
                {
                    name = r.Name;
                }
                else
                {
                    name = this.txtSearchW_Name.Text;
                }

                if (this.txtSearchW_Cal1.Text == "")
                {
                    cal1 = r.Calories;
                }
                else
                {
                    cal1 = double.Parse(this.txtSearchW_Cal1.Text);
                }

                if (this.txtSearchW_Cal2.Text == "")
                {
                    cal2 = r.Calories;
                }
                else
                {
                    cal2 = double.Parse(this.txtSearchW_Cal2.Text);
                }

                if ((int)this.cmbSearchW_WC.SelectedValue == -1)
                {
                    wcID = r.WorkoutCategoryID;
                }
                else
                {
                    wcID = (int)this.cmbSearchW_WC.SelectedValue;
                }

                if ((int)this.cmbSearchW_AL.SelectedValue == -1)
                {
                    alID = r.ActivityLevelID;
                }
                else
                {
                    alID = (int)this.cmbSearchW_AL.SelectedValue;
                }

                flag &= r.Name.Contains(name);
                flag &= r.Calories >= cal1 && r.Calories <= cal2;
                flag &= r.WorkoutCategoryID == wcID;
                flag &= r.ActivityLevelID == alID;
                return flag;
            }).ToList();

            this.dgvW.Columns["Delete"].DisplayIndex = this.dgvW.Columns.Count - 1;
        }

        #endregion

        #region BindingSource
        private void bsWC_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (this.bsWC.Count == 0)
            {
                LoadCmbBox(this.bsWC, "Name", "ID", this.cmbAddW_WC, this.cmbEditW_WC);
            }
            else
            {
                LoadCmbBox(this.bsWC, "Name", "ID", this.cmbAddW_WC, this.cmbEditW_WC);
            }
            
            
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
                this.bsWC.Position = e.NewIndex;
            }
        }

        private void bsW_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded)
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
            this.txtEditWC_Name.Text = this.txtEditWC_Name_Old.Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.txtEditW_Name.Text = this.txtEditW_Name_Old.Text;
        }


        #endregion
    }

    #region partial class test
    public partial class Workout
    {
        public string ActivityLevelDescription
        {
            get
            {
                return ActivityLevel.Description;
            }
        }

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
