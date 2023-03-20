using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace ClothesManagementSystem
{
    public partial class FormShopping : Form
    {
        private IconButton currentBtn;
        //private Panel leftBorderBtn;
        private Form currentChildForm;
        public FormShopping()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(248, 249, 100);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void Reset()
        {
            DisableButton();
         

        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                //leftBorderBtn.BackColor = color;
             //  leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
               // leftBorderBtn.Visible = true;
              //  leftBorderBtn.BringToFront();
                //Current Child Form Icon
              //  iconCurrentChildForm.IconChar = currentBtn.IconChar;
               // iconCurrentChildForm.IconColor = color;
            }

        }

        private void BtnWomanFashion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormWoman());
        }

        private void BtnMaleFashion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FormMale());
        }

        private void BtnBag_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormBag());
        
        }

        private void BtnJewelry_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormJewelry());
        }

        private void BtnKidFashion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new FormChildren());
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            if(currentBtn != null)
            {
                currentChildForm.Close();
                Reset();
            }
        }

        private void FormShopping_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnCart_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormShoppingCart());
        }

		private void btnBag_Click_1(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color6);
			OpenChildForm(new FormBag());
		}

		private void btnJewelry_Click_1(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color6);
			OpenChildForm(new FormJewelry());
		}
	}
}
