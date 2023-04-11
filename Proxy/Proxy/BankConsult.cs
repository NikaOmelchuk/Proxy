
namespace Proxy
{
    public interface BankConsult
    {
        string GetCons(int q);
    }

    public class BankCons : BankConsult
    {
        public string GetCons(int q)
        {
            switch (q)
            {
                case 1:
                    return "Необхiдно мати iдентифiкацiйний документ та поштову адресу.";

                case 2:
                    return "Ви можете поповнити рахунок через банкомат, iнтернет-банкiнг або шляхом переказу з iншого рахунку.";

                case 3:
                    return "Мiнiмальна сума для зняття залежить вiд банку та типу картки. Зазвичай це 100 грн або еквiвалентна сума в iншiй валютi.";
                case 4:
                    return "Наш банк славиться гарною фiнансовою стабiльнiстю та захищенiстю даних";
                default:
                    return "Помилка! спробуйте ще раз";
            }
        }
    }

  
    public class BankConsProxy : BankConsult
    {
        private BankCons bc;

        public BankConsProxy()
        {
            bc = new BankCons();
        }

        public string GetCons(int q)
        {
            string ans;
            if (q!=5)
            {
                ans = bc.GetCons(q);
                return ans;
            }
            else
                return "Вихiд";
        }
    }
}
