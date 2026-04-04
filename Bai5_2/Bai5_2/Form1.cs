namespace Bai5_2;

public partial class Form1 : Form
{
    private Label hsA;
    private Label hsB;
    private Label hsC;
    private Label nghiemPT;
    private TextBox nghiemA;
    private TextBox nghiemB;
    private TextBox nghiemC;
    private Button giai;
    private Button thoat;
    private Label ketQua;
    
    public Form1()
    {
        InitializeComponent();
        this.Text = "Giải phương trình bậc 2";
        this.Width = 880;
        this.Height = 240;
        
        // NGHIEM A
        hsA = new Label();
        hsA.Text = "Nhập hệ số a: ";
        hsA.Top = 20;
        hsA.Left = 20;
        hsA.Width = 140;
        hsA.Font = new Font(FontFamily.GenericSansSerif, 11);
        
        nghiemA = new TextBox();
        nghiemA.Top = 20;
        nghiemA.Left = 160;
        nghiemA.Width = 200;
        nghiemA.Height = 40;
        
        // NGHIEM B
        hsB = new Label();
        hsB.Text = "Nhập hệ số b: ";
        hsB.Top = 60;
        hsB.Left = 20;
        hsB.Width = 140;
        hsB.Font = new Font(FontFamily.GenericSansSerif, 11);
        
        nghiemB = new TextBox();
        nghiemB.Top = 60;
        nghiemB.Left = 160;
        nghiemB.Width = 200;
        nghiemB.Height = 40;
        
        //NGHIEM C
        hsC = new Label();
        hsC.Text = "Nhập hệ số c: ";
        hsC.Top = 100;
        hsC.Left = 20;
        hsC.Width = 140;
        hsC.Font = new Font(FontFamily.GenericSansSerif, 11);
        
        nghiemC = new TextBox();
        nghiemC.Top = 100;
        nghiemC.Left = 160;
        nghiemC.Width = 200;
        nghiemC.Height = 40;
        
        //GIAI BUTTON
        giai = new Button();
        giai.Width = 170;
        giai.Height = 40;
        giai.Top = 140;
        giai.Left = 20;
        giai.Text = "Giải";
        giai.Font = new Font(FontFamily.GenericSansSerif, 11);
        giai.Click += button1_Click;
        
        //THOAT BUTTON
        thoat = new Button();
        thoat.Width = 170;
        thoat.Height = 40;
        thoat.Top = 140;
        thoat.Left = 190;
        thoat.Text = "Thoát";
        thoat.Font = new Font(FontFamily.GenericSansSerif, 11);
        thoat.Click += button2_Click;
        
        // NGHIEM PHUONG TRINH
        nghiemPT = new Label();
        nghiemPT.Text = "Nghiệm của phương trình: ";
        nghiemPT.Top = 20;
        nghiemPT.Left = 400;
        nghiemPT.Width = 400;
        nghiemPT.Font = new Font(FontFamily.GenericSansSerif, 11);
        
        // MESSAGE BOX
        ketQua = new Label();
        ketQua.Top = 60;
        ketQua.Left = 400;
        ketQua.Width = 440;
        ketQua.Height = 120;
        ketQua.BorderStyle = BorderStyle.FixedSingle;
        ketQua.Font = new Font("Tahoma", 14);
        ketQua.Text = ""; 
        
        this.Controls.Add(hsA);
        this.Controls.Add(nghiemA);
        this.Controls.Add(hsB);
        this.Controls.Add(nghiemB);
        this.Controls.Add(hsC);
        this.Controls.Add(nghiemC);
        this.Controls.Add(giai);
        this.Controls.Add(thoat);
        this.Controls.Add(nghiemPT);
        this.Controls.Add(ketQua);
        
    }

    public void button1_Click(object sender, EventArgs e)
    {
        if (double.TryParse(nghiemA.Text, out double a))
        {
            a = Convert.ToDouble(nghiemA.Text);
            
            if (double.TryParse(nghiemB.Text, out double b))
            {
                b = Convert.ToDouble(nghiemB.Text);
                
                if (double.TryParse(nghiemC.Text, out double c))
                {
                    c = Convert.ToDouble(nghiemC.Text);
                    
                    double delta = b * b - (4 * a * c);
                    if (delta < 0)
                    {
                        ketQua.Text = "Phương trình vô nghiệm";
                    } else if (delta == 0)
                    {
                        double x = -b / (2 * a);
                        ketQua.Text = "Phương trình có nghiệm kép: " + x;
                    }
                    else
                    {
                        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                        ketQua.Text = "Phương trình có 2 nghiệm: x1 = " + x1 + ", x2 = " + x2;
                    }
                }
                else
                {
                    ketQua.Text = "Số c mà bạn nhập không phải là số hợp lệ";
                }
            }
            else
            {
                ketQua.Text = "Số b mà bạn nhập không phải là số hợp lệ";
            }
        }
        else
        {
            ketQua.Text = "Số a bạn nhập không phải là số hợp lệ";
        }
    }

    public void button2_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}