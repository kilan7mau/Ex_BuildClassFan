namespace BuildClassFan;

public class Fan
{
    

    //2 hằng được đặt tên là SLOW, MEDIUM, và FAST với giá trị 1, 2, và 3 để biểu thị tốc độ quạt.
    public const int SLOW = 1;
    public const int MEDIUM = 2;
    public const int FAST = 3;
    //Trường speed có kiểu số nguyên (private int) để xác định tốc độ quạt, mặc định là SLOW
    private int speed = SLOW;
    //Trường on có kiểu private bool để xác định quạt đang bật hay tắt, mặc định là false (tắt).
    private bool on = false;
    //Trường radius có kiểu private double để xác định bán kính quạt, giá trị mặc định là 5
    private double radius = 5;
    //Trường color có kiểu dữ liệu private string để xác định màu quạt, mặc định là blue
    private string color = "blue";
    
    //Các getter và setter cho các thuộc tính
    public int Speed
    {
        get => speed;
        set => speed = value;
    }

    public bool On
    {
        get => on;
        set => on = value;
    }

    public double Radius
    {
        get => radius;
        set => radius = value;
    }

    public string Color
    {
        get => color;
        set => color = value;
    }
    //Phương thức khởi tạo không tham số tạo đối tượng fan mặc định
    public Fan()
    {
        
    }
    //Phương thức ToString() trả về chuỗi chứa thông tin của quạt. Nếu quạt đang ở trạng thái on,
    //phương thức trả về speed, color, và radius với chuỗi “fan is on”.
    //Nếu quạt không ở trạng thái on, phương thức trả về color, radius với chuỗi “fan is off”.
    public override string ToString()
    {
        if (on)
        {
            return $"Speed: {speed}, Color: {color}, Radius: {radius}, fan is on";
        }
        else
        {
            return $"Color: {color}, Radius: {radius}, fan is off";
        }
    }
}