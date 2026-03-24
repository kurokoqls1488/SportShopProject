using Microsoft.EntityFrameworkCore;
using SportShopProject.Models;
using SportShopProject.Properties;

namespace SportShopProject
{
    public partial class FormSportGoods : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }
        public FormSportGoods(User user, bool guest)
        {
            InitializeComponent();

            /*var colPhoto = new DataGridViewImageColumn();
            colPhoto.Name = "colPhoto";
            colPhoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colPhoto.Width = 250;
            colPhoto.FillWeight = 40;*/

            var colInfo = new DataGridViewTextBoxColumn();
            colInfo.Name = "colInfo";
            colInfo.FillWeight = 70;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            var colDiscount = new DataGridViewTextBoxColumn();
            colDiscount.Name = "colDiscount";
            colDiscount.FillWeight = 20;
            colDiscount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewSportGoods.Columns.AddRange(
            [
                /*colPhoto, */colInfo, colDiscount
            ]);

            CurrentUser = user;
            IsGuest = guest;

            labelUserName.Text = IsGuest ? "Гость" : CurrentUser.FullName;

            LoadSportGoods();
        }

        private void LoadSportGoods()
        {
            try
            {
                using (var db = new SportShopDbContext())
                {
                    var sportGoods = db.SportsGoods
                        .Include(i => i.Category)
                        .Include(i => i.Manufacturer)
                        .Include(i => i.Supplier)
                        .Include(i => i.UnitsOfMeasurement)
                        .ToList();

                    dataGridViewSportGoods.SuspendLayout();
                    dataGridViewSportGoods.Rows.Clear();

                    foreach (var sportGood in sportGoods)
                    {
                        int rowIndex = dataGridViewSportGoods.Rows.Add();
                        var row = dataGridViewSportGoods.Rows[rowIndex];

                        //row.Cells["colPhoto"].Value = Resources.picture;

                        row.Cells["colInfo"].Value = FormatProductInfo(sportGood);

                        row.Cells["colDiscount"].Value = $"{sportGood.Discount}%";
                        row.Cells["colDiscount"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        ApplyRowStyles(row, sportGood);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyRowStyles(DataGridViewRow row, SportsGood sportGood)
        {
            if (sportGood.Discount > 15)
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2E8B57");
                row.DefaultCellStyle.ForeColor = Color.White;
            }
            if (sportGood.CountInStock <= 0)
            {
                row.DefaultCellStyle.BackColor = Color.LightBlue;
                if (sportGood.CountInStock <= 15)
                {
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }

            if (sportGood.Discount > 0)
            {
                row.Cells["colDiscount"].Style.ForeColor = Color.Red;
                row.Cells["colDiscount"].Style.Font = new Font(
                    "Times New Roman",
                    12,
                    FontStyle.Bold);
            }
        }

        private string FormatProductInfo(SportsGood sportGood)
        {
            string priceText;

            if (sportGood.Discount > 0)
            {
                decimal finalPrice = sportGood.Price * (100 - sportGood.Discount) / 100;
                priceText = $"Цена: {sportGood.Price:C} -> Insert {finalPrice:C}";
            }
            else
            {
                priceText = $"Цена: {sportGood.Price:C}";
            }
            return $"{sportGood.Category.CategoryName}" + Environment.NewLine +
                $"Описание товара: {sportGood.Description}" + Environment.NewLine +
                $"Производитель: {sportGood.Manufacturer.NameManufacturer}" + Environment.NewLine +
                $"Поставщик: {sportGood.Supplier.NameSupplier}" + Environment.NewLine +
                $"Цена: {priceText}" + Environment.NewLine +
                $"Единица измерения: {sportGood.UnitsOfMeasurement.NameUnits}" + Environment.NewLine +
                $"Количество на складе: {sportGood.CountInStock}";
        }

       /* private Image LoadSportGoodsImage(string photoUrl)
        {
            if (!String.IsNullOrEmpty(photoUrl) && System.IO.File.Exists(photoUrl))
            {
                return Image.FromFile(photoUrl);
            }

            return Resources.picture;
        }*/

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
