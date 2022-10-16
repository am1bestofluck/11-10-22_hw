// инит

// делаем функцию которая принимает два инта.. а на выходе дает самое большое что вообще есть. Лонг?

// Валидация какая?

// Степень целое положительное, основание целое
//upd: основание целое это слишком скучно :( :D
// Обработать переполнение
using static System.Console;
class custom_pow
{
    int _base;
    double _base_double;//ну а чо :)
    uint _multiply_by;
    double base_superior;//перегрузки перегрузками но по итогу нужно будет что-то выбрать.
    bool is_multiplier_valid;
    // public custom_pow(int base_num, uint multiply_num){
    //      this._base=base_num;
    //      this._multiply_by=multiply_num;
    // }
    public custom_pow(double base_num, uint multiply_num){
         this._base_double=base_num;
         this._multiply_by=multiply_num;
    }
    private dynamic check_input(){
       try
       {
        this.base_superior=this._base_double;
       }
       catch (System.Exception)
       {
        
        throw;
       }
        this.is_multiplier_valid=true;
        if (this._multiply_by<0)
        {
            this.is_multiplier_valid=false;//по условию отрицательные степени не допускаются...вроде как
        }
        return null;
    }
    private dynamic core(){        
        decimal output=Decimal.One;//...ёмаё
        Decimal prev_value=Decimal.Zero;
        if (this.is_multiplier_valid==false)
        {
            WriteLine("по условию отрицательные и дробные степени степени не допускаются");
            return output;
        }
        for (int walk = 0; walk < _multiply_by; walk++)
        {
            try
            {
                output=output*Convert.ToDecimal(base_superior);                
            }
            catch (System.OverflowException)
            {
                WriteLine($"Ошибка переполнения при возведении {this.base_superior}**{walk-1} ({prev_value}) в степень {walk}");
                return Decimal.Zero;
            }
        prev_value=output;
        }
        output=Math.Round(output,4);
        return output;
    }
    public dynamic represent()
    {
        WriteLine($"Возводим {this.base_superior} в степень {this._multiply_by}");
        return null;
    }
    public dynamic main()
    {
       this.check_input();
       this.represent();
       decimal output_main=this.core();
       return output_main;
    }
}