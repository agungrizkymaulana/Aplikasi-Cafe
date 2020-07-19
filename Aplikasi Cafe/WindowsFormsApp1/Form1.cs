using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmdjenis.items.Add("Roti Prata")
            cmdjenis.items.Add("Minuman")
            cmdjenis.items.Add("Blanded")
            cmdjenis.items.Add("Soft Drink")
            cmdjenis.items.Add("Dessert")
            cmdjenis.items.Add("Juice")
        }

        private void label1_Click(object sender, EventArgs e)
        {
            If cmdjenis.Text = "Roti Prata" Then
     cmdnama.Items.clear()
     cmdnama.Text = ""
     cmdnama.Items.Add("Coco Roti Tissu")
     cmdnama.Items.Add("Sweet Roti Tissu")
     cmdnama.Items.Add("Keju Roti Tissu")
     cmdnama.Items.Add("Milo Roti tissu")
     cmdnama.Items.Add("Roti Bom ice cream")
     cmdnama.Items.Add("Roti Bom Banana Splite")
     cmdnama.Items.Add("Roti Bom Ovamaltine")
     cmdnama.Items.Add("Roti Bom Nuttela")
     cmdnama.Items.Add("Double egg Prata")
     cmdnama.Items.Add("Prata Egg and Cheese")
     cmdnama.Items.Add("Cheese and Mushroom Prata")

 ElseIf cmdjenis.Text = "Minuman" Then
     cmdnama.Items.clear()
     cmdnama.Text = ""
     cmdnama.Items.Add("Teh Manis")
     cmdnama.Items.Add("Teh Tarik")
     cmdnama.Items.Add("Kopi Tarik")
     cmdnama.Items.Add("Ice Coffe Milo")
     cmdnama.Items.Add("Hot Teh Manis")
     cmdnama.Items.Add("Hot Teh Tarik")
     cmdnama.Items.Add("Hot Kopi Tarik")
     cmdnama.Items.Add("Ice Lemon Tea")
     cmdnama.Items.Add("Hot Lemon Tea")
     cmdnama.Items.Add("Ice Coffe Coklat")
     cmdnama.Items.Add("Ice Coffe Milk Boba")

ElseIf cmdjenis.Text = "Blanded" Then
     cmdnama.Items.clear()
     cmdnama.Text = ""
     cmdnama.Items.Add("Dark Chocolate Boba")
     cmdnama.Items.Add("Chocolate Blende")
     cmdnama.Items.Add("Cappucino Blende")
     cmdnama.Items.Add("Cappucino Boba")
     cmdnama.Items.Add("Dark Nuttela Ice Cream")
     cmdnama.Items.Add("Manggo Boba")
ElseIf cmdjenis.Text = "Soft Drink" Then
     cmdnama.Items.clear()
     cmdnama.Text = ""
     cmdnama.Items.Add("Mineral")
     cmdnama.Items.Add("Sprite")
     cmdnama.Items.Add("Coca cola")
     cmdnama.Items.Add("Fanta")
ElseIf cmdjenis.Text = "Dessert" Then
     cmdnama.Items.clear()
     cmdnama.Text = ""
     cmdnama.Items.Add("Thai Manggo Ice")
     cmdnama.Items.Add("Red Bean Ice Cendol")
     cmdnama.Items.Add("Durian Ice Cendol")
     cmdnama.Items.Add("Penang Ice Kacang")
     cmdnama.Items.Add("Taro Ice Jelly")
     cmdnama.Items.Add("Durian Ice Jelly")
     cmdnama.Items.Add("Green Tea Ice Jelly")
     cmdnama.Items.Add("Strowberry Ice Jelly")
ElseIf cmdjenis.Text = "Juice" Then
     cmdnama.Items.clear()
     cmdnama.Text = ""
     cmdnama.Items.Add("Manggo Juice")
     cmdnama.Items.Add("Avocado Juice")
     cmdnama.Items.Add("Watermelon Juice")
     cmdnama.Items.Add("Melon Juice")
     cmdnama.Items.Add("Markisa Juice")
     cmdnama.Items.Add("Wortel Juice")
     cmdnama.Items.Add("Timun Juice")
     cmdnama.Items.Add("Belimbing Juice")
     cmdnama.Items.Add("Tomat Juice")
     cmdnama.Items.Add("Kedondong Juice")
  End If
        }

        private void cmdjenis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
