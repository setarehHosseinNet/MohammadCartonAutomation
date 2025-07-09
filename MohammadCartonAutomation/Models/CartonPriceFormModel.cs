using Microsoft.Extensions.Hosting;
using System.Runtime.ConstrainedExecution;

namespace MohammadCartonAutomation.Models
{
    public class CartonPriceFormModel
    {
        // اطلاعات عمومی
        public string CustomerName { get; set; } = string.Empty;//نام مشتری
        public string PhoneNumber { get; set; } = string.Empty;//شماره تماس
        public string ProductCode { get; set; } = string.Empty;//کد محصول
        public string ProductName { get; set; } = string.Empty;//نام محصول
        public int Quantity { get; set; } //تیراژ کارتن
        public DateTime RegisterDateEndOrder { get; set; } = DateTime.Now;// تاریخ اخرین سفارش
        public int Priceperlastorder { get; set; }//قیمت فی آخرین سفارش
        public int PriceEndOrder { get; set; }//نرخ آخرین سفارش
        public DateTime RegisterDate { get; set; } = DateTime.Now;// تاریخ ثبت
        public string OperatorName { get; set; } = string.Empty;//اپراتور ثبت

        // وضعیت نمونه و تبدیل
        public bool HasPrintOrConvert { get; set; }     // چاپ و نکات تبدیل
        public string SampleType { get; set; } = string.Empty; // نمونه مشتری یا ابعاد مشتری
        public List<string> AdditionalOptions { get; set; } = new(); // کلیشه، دسته، منگنه و ...

        // مشخصات کارتن
        public string CartonType { get; set; } = string.Empty; // سه لایه، پنج لایه
        //public string LayerCount { get; set; } = string.Empty;//
        public string PieceType { get; set; } = string.Empty;  // یک تکه، نیم کارتن، چهار تکه
        public string DoorType { get; set; } = string.Empty;   // درب باز، بسته، دوبل
        public int DoorCount { get; set; }//دو درب، تک درب

        // ابعاد کارتن
        public double Length { get; set; }//طول 
        public double Width { get; set; }//عرض
        public double Height { get; set; }//ارتفاع

        // محاسبات
        public double CalculatedSheet { get; set; }//محاسبه شیت
        public double LipLength { get; set; }//لب درب
        public double IndustrialLength { get; set; }//طول صنعتی
        public double IndustrialWidth { get; set; }//عرض صنعتی
        public bool IsIndustrialWidthValid { get; set; }//بررسی صحت عرض صنعتی
        public int NumberObtainedFromEachSheet { get; set; }//تعداد بدست آمده از هر ورق
        // ورق خام
        public double SheetLength { get; set; }//طول ورق
        public double SheetWidth { get; set; }//عرض ورق
        public int SheetCountPerCarton { get; set; }// ضایعات محاسباتی

        // مشخصات لایه‌ها
        public string FlutStep { get; set; } = string.Empty;//گام فلوت
        public string GlueMachine { get; set; } = string.Empty;//ماشین چسب
        public string BE_Flut { get; set; } = string.Empty;//فلوت B/E
        public string MiddleLayer { get; set; } = string.Empty;//لایه میانی
        public string CFlut { get; set; } = string.Empty;//فلوت C
        public string BottomLayer { get; set; } = string.Empty;//زیره

        // هزینه‌ها
        public int OverheadCostPerMeter { get; set; }//هزینه سربار به ازای هر متر
        public int CashPricePerSheet { get; set; }//فی ورق نقد
        public int CreditPricePerSheet { get; set; }//فی ورق مدت دار
        public double SheetArea { get; set; }//متراژ ورق
        public double NumberOfSheets { get; set; }//تعداد ورق
        public int ProfitRate { get; set; }//نرخ سود
        public int SlagCostFactor { get; set; }//مایه کاری هزینه سرباره
        public int SheetMetalWork { get; set; }//مایه کاری ورق
        public int TransportCost { get; set; }//هزینه حمل و نقل
        public int PalletCost { get; set; }//هزینه پالت بندی
        public int InterfaceCost { get; set; }// هزینه رابط

        // نوع پرداخت و تکمیل
        public string PaymentType { get; set; } = string.Empty;  // نقدی یا اعتباری
       

        // فنی و چاپ
        //public double LipDistance { get; set; }
        //public string PrintType { get; set; } = string.Empty;
        //public string PrintColor { get; set; } = string.Empty;
        //public string DieCut { get; set; } = string.Empty;
        //public string BindingType { get; set; } = string.Empty;

        // نتایج نهایی محاسبه
        public double ConsumptionPerCarton { get; set; } // (طول × عرض) ÷ تعداد × 10000
        public decimal FinalPriceNoTax { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal FinalPriceWithTax { get; set; }

        // ورق انتخابی
        public string SelectedSheet { get; set; } = string.Empty;

        // توضیحات
        public string Notes { get; set; } = string.Empty;
    }

}
