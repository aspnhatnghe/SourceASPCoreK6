using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D01_Intro.Models
{
    public class HinhChuNhat
    {
        //Field
        private double dai;
        //sinh ra Property
        public double Dai
        {
            get { return dai; }
            set
            {
                if (value > 0)
                    dai = value;
                else throw new Exception("Dai am");
            }
        }

        //Automatic Property
        public double Rong { get; set; }

        //Property chỉ get (từ C# 7.0 trở lên)
        public double ChuVi => (Dai + Rong) * 2;//C# 7.0

        public double S => Dai * Rong;//C# 7.0
        public double DienTich
        {
            get { return Dai * Rong; }
        }

        public string Chuoi()
        {
            return $"HCN dài {Dai}, rộng {Rong} có diện tích {DienTich}, chu vi {ChuVi}";
        }
    }
}
