using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bearing
{
    public class Bearing
    {
        [Description("Марка подшипника")]
        [Category("Атрибуты")]
        [DisplayName("Марка")]
        public string Name { get; set; } = "6805-72";
        [Description("")]
        [Category("Основные размеры")]
        [DisplayName("Внутренний диаметр")]
        public double d_in { get; set; } = 25;
        [Description("")]
        [Category("Основные размеры")]
        [DisplayName("Наружный диаметр")]
        public double d_out { get; set; } = 52;
        [Description("Ширина подшипника")]
        [Category("Основные размеры")]
        [DisplayName("Ширина")]
        public double b { get; set; } = 26;
        [Description("")]
        [Category("Размеры тел качения")]
        [DisplayName("Диаметр тела качения")]
        public double b1 { get; set; } = 5;
        [Description("")]
        [Category("Размеры тел качения")]
        [DisplayName("Количество")]
        public int kb { get; set; } = 16;
        [Description("")]
        [Category("Размеры тел качения")]
        [DisplayName("Диаметр окружности тел качения")]
        public double d_b { get; set; } = 38;

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString()+
                $"d / D / B = {d_in} / {d_out} / {b}"+
                $"b / z / d = {b1} / {kb} / {d_b}";
        }
    }
}
