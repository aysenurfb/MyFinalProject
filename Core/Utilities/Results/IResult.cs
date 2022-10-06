using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //temel voidler için başlangıç. sadece hata mesajı içinde bir şey döndürmeyecek gösterecek. o yüzden sadece get var
    public interface IResult
    {
        //işlem başarılı mı başarısız mı? onu gostermek için. o yuzden bool
        bool Success { get; }

        //basarı ya da başarısız mesajı
        string Message { get; }
    }
}
