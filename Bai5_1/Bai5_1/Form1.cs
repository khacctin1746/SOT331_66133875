namespace Bai5_1;

public partial class Form1 : Form
{
    private Label nhapBanKinh;
    private TextBox txtA;
    private Button button1;
    private Button button2;
    private Button button3;
    private Label ketQua;
    
    public Form1()
    {
        InitializeComponent();
        
        // form chinh
        this.Text = "Tính chu vi, diện tích hình tròn";
        this.Width = 560;
        this.Height = 280;
        
        //
        nhapBanKinh = new Label();
        nhapBanKinh.Text = "Nhập bán kính hình tròn: ";
        nhapBanKinh.Top = 20;
        nhapBanKinh.Left = 20;
        nhapBanKinh.Font = new Font("Tahoma", 14, FontStyle.Bold);
        nhapBanKinh.AutoSize = true;
        
        //textbox A
        txtA = new TextBox();
        txtA.Top = 20;
        txtA.Left = 352;
        txtA.Width = 166;
        txtA.Height = 40;
        
        //Button tinh chu vi
        button1 = new Button();
        button1.Top = 60;
        button1.Left = 20;
        button1.Text = "Chu Vi";
        button1.Width = 166;
        button1.Height = 40;
        button1.Font = new Font("Tahoma", 11);
        button1.Click += button1_Click_1;
        
        //Button tinh dien tich
        button2 = new Button();
        button2.Top = 60;
        button2.Left = 186;
        button2.Text = "Dien Tich";
        button2.Width = 166;
        button2.Height = 40;
        button2.Font = new Font("Tahoma", 11);
        button2.Click += button2_Click_1;
        
        //Button tinh thoat
        button3 = new Button();
        button3.Top = 60;
        button3.Left = 352;
        button3.Text = "Thoat";
        button3.Width = 166;
        button3.Height = 40;
        button3.Font = new Font("Tahoma", 11);
        button3.Click += button3_Click_1;
        
        //MessageBox
        ketQua = new Label();
        ketQua.Top = 110;
        ketQua.Left = 20;
        ketQua.Width = 500;
        ketQua.Height = 100;
        ketQua.BorderStyle = BorderStyle.FixedSingle; // viền giống hình
        ketQua.Font = new Font("Tahoma", 14);
        ketQua.Text = ""; 
        
        //add vao form
        this.Controls.Add(nhapBanKinh);
        this.Controls.Add(txtA);
        this.Controls.Add(button1);
        this.Controls.Add(button2);
        this.Controls.Add(button3);
        this.Controls.Add(ketQua);
    }

    public void Form1_Load(object sender, EventArgs e)
    {
        
    }

    public void button1_Click_1(object sender, EventArgs e)
    {

        if (double.TryParse(txtA.Text, out double banKinh))
        {
            banKinh = Convert.ToDouble(txtA.Text);
            double chuVi = 2 * Math.PI * banKinh;
            ketQua.Text = "Chu vi hình tròn = " + chuVi;
        }
        else
        {
            ketQua.Text = "Bạn nhập số không hợp lệ!";
        }
    }

    public void button2_Click_1(object sender, EventArgs e)
    {
        if (double.TryParse(txtA.Text, out double banKinh))
        {
            double dienTich;
            banKinh = Convert.ToDouble(txtA.Text);
            dienTich = dienTich = Math.PI * banKinh * banKinh;
            ketQua.Text = "Diện tích hình tròn = " + dienTich;
        }
        else
        {
            ketQua.Text = "Bạn nhập số không hợp lệ!";
        }
    }

    public void button3_Click_1(object sender, EventArgs e)
    {
        this.Close();
    }
}