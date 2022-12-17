using System;
using System.Windows.Input;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ColorConverter
{
    public partial class Form1 : Form
    {
        List<TextBox> groupBox1;
        List<TextBox> groupBox2;
        List<TextBox> groupBox3;
        List<List<TextBox>> groupBoxAll;

        List<TrackBar> groupBar1;
        List<TrackBar> groupBar2;
        List<TrackBar> groupBar3;
        List<List<TrackBar>> groupBarAll;

        List<Label> labels;

        private static void GroupTextBoxes(List<TextBox> list, TextBox tb1, TextBox tb2, TextBox tb3, TextBox tb4)
        {
            list.Add(tb1);
            list.Add(tb2);
            list.Add(tb3);
            list.Add(tb4);
        }

        private static void GroupBars(List<TrackBar> list, TrackBar tb1, TrackBar tb2, TrackBar tb3, TrackBar tb4)
        {
            list.Add(tb1);
            list.Add(tb2);
            list.Add(tb3);
            list.Add(tb4);
        }

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            DoubleBuffered = true;
            groupBox1 = new List<TextBox>();
            GroupTextBoxes(groupBox1, tBox1, tBox2, tBox3, tBox4);
            groupBox2 = new List<TextBox>();
            GroupTextBoxes(groupBox2, tBox5, tBox6, tBox7, tBox8);
            groupBox3 = new List<TextBox>();
            GroupTextBoxes(groupBox3, tBox9, tBox10, tBox11, tBox12);

            groupBoxAll = new List<List<TextBox>>();
            groupBoxAll.Add(groupBox1);
            groupBoxAll.Add(groupBox2);
            groupBoxAll.Add(groupBox3);

            groupBar1 = new List<TrackBar>();
            GroupBars(groupBar1, trackBar11, trackBar12, trackBar13, trackBar14);
            groupBar2 = new List<TrackBar>();
            GroupBars(groupBar2, trackBar21, trackBar22, trackBar23, trackBar24);
            groupBar3 = new List<TrackBar>();
            GroupBars(groupBar3, trackBar31, trackBar32, trackBar33, trackBar34);

            groupBarAll = new List<List<TrackBar>>();
            groupBarAll.Add(groupBar1);
            groupBarAll.Add(groupBar2);
            groupBarAll.Add(groupBar3);

            labels = new List<Label>();
            labels.Add(label5);
            labels.Add(label6);
            labels.Add(label7);

            cbVariants.SelectedItem = cbVariants.Items[0];

            setValidation(label5);
            setValidation(label6);
            setValidation(label7);
            ChangeTBoxes();
        }

        public void setLight()
        {
            this.BackColor = SystemColors.Control;
            for (int i = 0; i < 3; i++)
            {
                labels.ElementAt(i).ForeColor = SystemColors.ControlText;
                for (int j = 0; j < 4; j++)
                {
                    groupBoxAll.ElementAt(i).ElementAt(j).BackColor = SystemColors.ControlLight;
                    groupBarAll.ElementAt(i).ElementAt(j).BackColor = SystemColors.Control;
                    groupBarAll.ElementAt(i).ElementAt(j).ForeColor = SystemColors.ControlDark;
                    groupBoxAll.ElementAt(i).ElementAt(j).ForeColor = SystemColors.ControlText;
                }
            }
            cbVariants.ForeColor = SystemColors.ControlText;
            cbVariants.BackColor = SystemColors.ButtonFace;
        }

        public void setDark()
        {
            this.BackColor = SystemColors.ControlDarkDark;
            for (int i = 0; i < 3; i++)
            {
                labels.ElementAt(i).ForeColor = SystemColors.ControlLight;
                for (int j = 0; j < 4; j++)
                {
                    groupBoxAll.ElementAt(i).ElementAt(j).BackColor = SystemColors.ControlDark;
                    groupBarAll.ElementAt(i).ElementAt(j).BackColor = SystemColors.ControlDarkDark;
                    groupBoxAll.ElementAt(i).ElementAt(j).ForeColor = SystemColors.ControlLight;
                    groupBarAll.ElementAt(i).ElementAt(j).ForeColor = SystemColors.ControlDarkDark;
                }
            }
            cbVariants.ForeColor = SystemColors.ControlLight;
            cbVariants.BackColor = SystemColors.AppWorkspace;
        }

        private void toRGB(int index)
        {
            int[] color = new int[4];
            Color clr = Color.White;
            for (int i = 0; i < 4; i++)
            {
                if (groupBoxAll.ElementAt(index).ElementAt(i).Text != "")
                {
                    color[i] = int.Parse(groupBoxAll.ElementAt(index).ElementAt(i).Text);
                }
                else
                {
                    color[i] = 0;
                }
            }
            switch (labels.ElementAt(index).Text)
            {
                case "RGB":
                    {
                        clr = Converter.fromRGB(color);
                        break;
                    }
                case "CMYK":
                    {
                        clr = Converter.fromCMYK(color);
                        break;
                    }
                case "HSV":
                    {
                        clr = Converter.fromHSV(color);
                        break;
                    }
                case "HSL":
                    {
                        clr = Converter.fromHSL(color);
                        break;
                    }
                case "XYZ":
                    {
                        clr = Converter.fromXYZ(color);
                        break;
                    }
                case "LAB":
                    {
                        clr = Converter.fromLab(color);
                        break;
                    }
            }
            pPalette.BackColor = clr;
        }

        private void fromRGB(Label lb)
        {
            int index = labels.LastIndexOf(lb);
            int[] color = new int[4] { 0, 0, 0, 0 };
            if (lb.Text == "RGB")
            {
                color = Converter.toRGB(pPalette.BackColor);
            }
            else if (lb.Text == "HSL")
            {
                color = Converter.toHSL(pPalette.BackColor);
            }
            else if (lb.Text == "HSV")
            {
                color = Converter.toHSV(pPalette.BackColor);
            }
            else if (lb.Text == "XYZ")
            {
                color = Converter.toXYZ(pPalette.BackColor);
            }
            else if (lb.Text == "CMYK")
            {
                color = Converter.toCMYK(pPalette.BackColor);
            }
            else if (lb.Text == "LAB")
            {
                color = Converter.toLab(pPalette.BackColor);
            }

            for (int i = 0; i < 3; i++)
            {
                groupBoxAll.ElementAt(index).ElementAt(i).Text = color[i].ToString();
                if (lb.Text == "CMYK") {
                    groupBoxAll.ElementAt(index).ElementAt(3).Text = color[3].ToString();
                }
            }
            recalculateGroupBars();
        }

        private bool isClicked = false;

        private void ChangeTBoxes()
        {
            for (int i = 0; i < 3; i++)
            {
                fromRGB(labels[i]);
            }
        }

        private void Fill(PictureBox pnl, MouseEventArgs e)
        {
            Bitmap pixelData = (Bitmap)pColorPad.Image;
            if ((e.X > 0 && e.X < pColorPad.Image.Width) && (e.Y > 0 && e.Y < pColorPad.Image.Height))
            {
                Color clr = pixelData.GetPixel(e.X, e.Y);
                pnl.BackColor = clr;
            }
            ChangeTBoxes();
        }

        private void giveError()
        {
            MessageBox.Show(
            "Invalid input, it was changed to 0",
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
        }

        private void giveWarning(int value)
        {
            MessageBox.Show(
            "Invalid input, it was changed to " + value,
            "Warning",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
        }

        private void callValidator(Label lb, TextBox tb)
        {
            bool isGood = int.TryParse(tb.Text, out _);
            if (tb.Text == "")
            {
                return;
            }
            else if (isGood)
            {
                int result = int.Parse(tb.Text);
                switch (lb.Text)
                {
                    case "RGB":
                        {
                            if (result > 255)
                            {
                                giveWarning(255);
                                tb.Text = "255";
                            }
                            else if (result < 0)
                            {
                                giveWarning(0);
                                tb.Text = "0";
                            }
                            break;
                        }
                    case "CMYK":
                        {
                            if (result > 100)
                            {
                                giveWarning(100);
                                tb.Text = "100";
                            }
                            else if (result < 0)
                            {
                                giveWarning(0);
                                tb.Text = "0";
                            }
                            break;
                        }
                    case "HSV":
                    case "HSL":
                        {
                            int index = labels.LastIndexOf(lb);
                            if (tb == groupBoxAll.ElementAt(index).ElementAt(0))
                            {
                                if (result > 360)
                                {
                                    giveWarning(360);
                                    tb.Text = "360";
                                }
                                else if (result < 0)
                                {
                                    giveWarning(0);
                                    tb.Text = "0";
                                }
                                break;
                            }
                            else if (result > 100)
                            {
                                giveWarning(100);
                                tb.Text = "100";
                            }
                            else if (result < 0)
                            {
                                giveWarning(0);
                                tb.Text = "0";
                            }
                            break;
                        }
                    case "XYZ":
                        {
                            if (result > 100)
                            {
                                giveWarning(100);
                                tb.Text = "100";
                            }
                            else if (result < 0)
                            {
                                giveWarning(0);
                                tb.Text = "0";
                            }
                            break;
                        }
                    case "LAB":
                        {
                            int index = labels.LastIndexOf(lb);
                            if (tb == groupBoxAll.ElementAt(index).ElementAt(0))
                            {
                                if (result > 100)
                                {
                                    giveWarning(100);
                                    tb.Text = "100";
                                }
                                else if (result < 0)
                                {
                                    giveWarning(0);
                                    tb.Text = "0";
                                }
                                break;
                            }
                            else if (result > 127)
                            {
                                giveWarning(127);
                                tb.Text = "127";
                            }
                            else if (result < -128)
                            {
                                giveWarning(-128);
                                tb.Text = "-128";
                            }
                            break;
                        }
                }
            }
            else
            {
                giveError();
                tb.Text = "0";
            }
        }

        private void setValidation(Label lb)
        {
            int index = labels.LastIndexOf(lb);
            switch (lb.Text)
            {
                case "RGB":
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            groupBarAll.ElementAt(index).ElementAt(i).Minimum = 0;
                            groupBarAll.ElementAt(index).ElementAt(i).Maximum = 255;
                        }
                        break;
                    }
                case "CMYK":
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            groupBarAll.ElementAt(index).ElementAt(i).Minimum = 0;
                            groupBarAll.ElementAt(index).ElementAt(i).Maximum = 100;
                        }
                        break;
                    }
                case "HSV":
                case "HSL":
                    {
                        groupBarAll.ElementAt(index).ElementAt(0).Minimum = 0;
                        groupBarAll.ElementAt(index).ElementAt(0).Maximum = 360;
                        for (int i = 1; i < 2; i++)
                        {
                            groupBarAll.ElementAt(index).ElementAt(i).Minimum = 0;
                            groupBarAll.ElementAt(index).ElementAt(i).Maximum = 100;
                        }
                        break;
                    }
                case "XYZ":
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            groupBarAll.ElementAt(index).ElementAt(i).Minimum = 0;
                            groupBarAll.ElementAt(index).ElementAt(i).Maximum = 109;
                        }
                        break;
                    }
                case "LAB":
                    {
                        groupBarAll.ElementAt(index).ElementAt(0).Minimum = 0;
                        groupBarAll.ElementAt(index).ElementAt(0).Maximum = 100;
                        for (int i = 1; i < 3; i++)
                        {
                            groupBarAll.ElementAt(index).ElementAt(i).Minimum = -128;
                            groupBarAll.ElementAt(index).ElementAt(i).Maximum = 128;
                        }
                        break;
                    }
            }
            if (lb.Text != "CMYK")
            {
                groupBoxAll.ElementAt(index).ElementAt(3).Visible = false;
                groupBarAll.ElementAt(index).ElementAt(3).Visible = false;
            }
            else
            {
                groupBoxAll.ElementAt(index).ElementAt(3).Visible = true;
                groupBarAll.ElementAt(index).ElementAt(3).Visible = true;
            }
        }

        public void setModels(int index)
        {
            string str1 = "", str2 = "", str3 = "";
            switch (index)
            {
                case 0:
                    {
                        str1 = "RGB";
                        str2 = "LAB";
                        str3 = "CMYK";
                        break;
                    }
                case 1:
                    {
                        str1 = "RGB";
                        str2 = "CMYK";
                        str3 = "HSL";
                        break;
                    }
                case 2:
                    {
                        str1 = "RGB";
                        str2 = "XYZ";
                        str3 = "LAB";
                        break;
                    }
                case 3:
                    {
                        str1 = "RGB";
                        str2 = "HSV";
                        str3 = "LAB";
                        break;
                    }
                case 4:
                    {
                        str1 = "CMYK";
                        str2 = "LAB";
                        str3 = "HSV";
                        break;
                    }
                case 5:
                    {
                        str1 = "CMYK";
                        str2 = "RGB";
                        str3 = "HSL";
                        break;
                    }
                case 6:
                    {
                        str1 = "CMYK";
                        str2 = "RGB";
                        str3 = "HSV";
                        break;
                    }
                case 7:
                    {
                        str1 = "RGB";
                        str2 = "XYZ";
                        str3 = "HSV";
                        break;
                    }
                case 8:
                    {
                        str1 = "HSV";
                        str2 = "XYZ";
                        str3 = "LAB";
                        break;
                    }
                case 9:
                    {
                        str1 = "CMYK";
                        str2 = "LAB";
                        str3 = "RGB";
                        break;
                    }
                case 10:
                    {
                        str1 = "XYZ";
                        str2 = "LAB";
                        str3 = "HSL";
                        break;
                    }
                case 11:
                    {
                        str1 = "RGB";
                        str2 = "XYZ";
                        str3 = "HSL";
                        break;
                    }
                case 12:
                    {
                        str1 = "RGB";
                        str2 = "XYZ";
                        str3 = "CMYK";
                        break;
                    }
                case 13:
                    {
                        str1 = "CMYK";
                        str2 = "LAB";
                        str3 = "XYZ";
                        break;
                    }
                case 14:
                    {
                        str1 = "RGB";
                        str2 = "CMYK";
                        str3 = "HSV";
                        break;
                    }
                case 15:
                    {
                        str1 = "CMYK";
                        str2 = "HSL";
                        str3 = "XYZ";
                        break;
                    }
                case 16:
                    {
                        str1 = "RGB";
                        str2 = "HSL";
                        str3 = "LAB";
                        break;
                    }
                case 17:
                    {
                        str1 = "CMYK";
                        str2 = "XYZ";
                        str3 = "RGB";
                        break;
                    }
            }

            labels.ElementAt(0).Text = str1;
            labels.ElementAt(1).Text = str2;
            labels.ElementAt(2).Text = str3;
        }

        public void recalculateGroupBar(List<TrackBar>list)
        {
            int index = groupBarAll.LastIndexOf(list);
            string str = "";
            for (int i = 0; i < 4; i++)
            {
                str = groupBoxAll.ElementAt(index).ElementAt(i).Text;
                if (str != "")
                {
                    groupBarAll.ElementAt(index).ElementAt(i).Value = int.Parse(groupBoxAll.ElementAt(index).ElementAt(i).Text);
                }
            }
        }

        public void recalculateGroupBars()
        {
            recalculateGroupBar(groupBar1);
            recalculateGroupBar(groupBar2);
            recalculateGroupBar(groupBar3);
        }

        public void changeValue(TrackBar tb, List<TrackBar> list)
        {
            int index = list.LastIndexOf(tb);
            int ind = groupBarAll.LastIndexOf(list);
            groupBoxAll.ElementAt(ind).ElementAt(index).Text = tb.Value.ToString();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClicked)
            {
                Fill(pPalette, e);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isClicked = true;
            Fill(pPalette, e);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e) => isClicked = false;

        private void groupBox1_KeyUp(object sender, KeyEventArgs e)
        {
            callValidator(label5, (TextBox)sender);
            toRGB(0);
            fromRGB(labels.ElementAt(1));
            fromRGB(labels.ElementAt(2));
        }

        private void groupBox2_KeyUp(object sender, KeyEventArgs e)
        {
            callValidator(label6, (TextBox)sender);
            toRGB(1);
            fromRGB(labels.ElementAt(0));
            fromRGB(labels.ElementAt(2));
        }

        private void groupBox3_KeyUp(object sender, KeyEventArgs e)
        {
            callValidator(label7, (TextBox)sender);
            toRGB(2);
            fromRGB(labels.ElementAt(0));
            fromRGB(labels.ElementAt(1));
        }

        private void cbVariants_SelectedIndexChanged(object sender, EventArgs e)
        {
            setModels(cbVariants.SelectedIndex);
            for (int i = 0; i < 3; i++)
            {
                setValidation(labels.ElementAt(i));
                fromRGB(labels.ElementAt(i));
            }
        }

        private void groupBar1_Scroll(object sender, EventArgs e)
        {
            toRGB(0);
            changeValue((TrackBar)sender, groupBar1);
            fromRGB(labels.ElementAt(1));
            fromRGB(labels.ElementAt(2));
            recalculateGroupBar(groupBar2);
            recalculateGroupBar(groupBar3);
        }

        private void groupBar2_Scroll(object sender, EventArgs e)
        {
            toRGB(1);
            changeValue((TrackBar)sender, groupBar2);
            fromRGB(labels.ElementAt(0));
            fromRGB(labels.ElementAt(2));
            recalculateGroupBar(groupBar1);
            recalculateGroupBar(groupBar3);
        }

        private void groupBar3_Scroll(object sender, EventArgs e)
        {
            toRGB(2);
            changeValue((TrackBar)sender, groupBar3);
            fromRGB(labels.ElementAt(0));
            fromRGB(labels.ElementAt(1));
            recalculateGroupBar(groupBar1);
            recalculateGroupBar(groupBar2);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
