using BusinessLayer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIMS.Products
{
    public partial class frmManageProducts : Form
    {
        private void _ApplyModernStyleToDGV()
        {
            // 1. إيقاف الستايل الافتراضي للويندوز لتفعيل ألواننا المخصصة للهيدر
            dgvProducts.EnableHeadersVisualStyles = false;

            // 2. إعدادات الهيدر (الشريط العلوي للجدول)
            dgvProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#1E293B"); // كحلي داكن
            dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvProducts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProducts.ColumnHeadersHeight = 40; // ارتفاع الهيدر

            // 3. تنسيق أسطر البيانات (Rows)
            dgvProducts.DefaultCellStyle.BackColor = Color.White;
            dgvProducts.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#334155");
            dgvProducts.DefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            dgvProducts.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // تناوب الألوان بين الأسطر (Alternating Rows) لسهولة القراءة
            dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F1F5F9");
            dgvProducts.RowTemplate.Height = 32; // ارتفاع الصف

            // 4. تنسيق الصف المحدد (Selected Row)
            dgvProducts.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#0EA5E9"); // أزرق سماوي
            dgvProducts.DefaultCellStyle.SelectionForeColor = Color.White;

            // 5. سلوك وحدود الجدول
            dgvProducts.BackgroundColor = ColorTranslator.FromHtml("#F8FAFC"); // خلفية الجدول الكلية
            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProducts.GridColor = ColorTranslator.FromHtml("#E2E8F0"); // لون الخطوط الفاصلة

            // 6. خصائص التحكم والاحترافية
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // توزيع الأعمدة بعرض الشاشة
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // تحديد الصف بالكامل عند الضغط
            dgvProducts.MultiSelect = false; // منع تحديد أكثر من صف في نفس الوقت
            dgvProducts.ReadOnly = true; // منع التعديل المباشر داخل الجدول
            dgvProducts.AllowUserToAddRows = false; // إخفاء الصف الفارغ في الأسفل
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.RowHeadersVisible = false; // إخفاء العمود الجانبي الصغير
        }
        public frmManageProducts()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = clsProduct.GetAllProducts();
            _ApplyModernStyleToDGV();
            lbProductscount.Text = "# " + dgvProducts.RowCount.ToString() + " Products";
        }

        private void ucProduct1_Load(object sender, EventArgs e)
        {

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowProductDetails frm = new frmShowProductDetails(Convert.ToInt32((dgvProducts.SelectedRows[0].Cells[0].Value)));
            frm.ShowDialog();
        }
    }
}
