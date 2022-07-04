using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class GamerManager : IGamerService
    {

        //Bir Manager sınıfında başka bir manager sınfına ihtiyaç varsa onu newleme

        IUserValidationService _userValidationService;                            //
                                                                                  //
        public GamerManager(IUserValidationService userValidationService)         //Şu satırlar yerine public void Add(Gamer gamer) kısmı
        {                                                                         //Public void Add(Gamer gamer, IUserValidationService userValidationService)
            _userValidationService = userValidationService;                       //olursa da olur
        }                                                                         //

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt olundu");
            }else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silimdi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}
