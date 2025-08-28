using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AttributePrac
{

    internal class Program
    {
        #region 사용자 지정특성 만들기
        //1 Attribute 클래스를 상쇽하여 사용자 지정 특성 만들기
        public class CustomAttribute : Attribute { }
        [Custom] void Test() => Console.WriteLine("Custom Attribute");

        public class SampleAttribute : Attribute
        {
            public SampleAttribute() => Console.WriteLine("사용자 지정 특성 사용됨");
        }

        [Sample]
        public class CustomAttributeTest { }

       
        #endregion
        static void Main(string[] args)
        {
            #region Obsolete특성 사용하기
            //아래의 구문과같이 Obsolete특성에 추가로 경고 메세지를 넣을 수 있다
            //[Obsolete("Using New Member Method")] void OldMember() => Console.WriteLine("Old Method");

            //아래의 구문과 같이 두번째 매개변수에 true를 넣으면 해당 메서드를 사용할 때 경고가 아닌 에러가 발생
            //[Obsolete("Using New Member Method", true)]void OldMember() => Console.WriteLine("Old Method");
            [Obsolete] void OldMember() => Console.WriteLine("Old Method");
            void NewMember() => Console.WriteLine("Nmew Method");
            OldMember();
            NewMember();
            #endregion

            #region 특성의 매개변수
            //위치 매개변수: 특성에 전달되는 매개변수는 위치에 따라 구분된다
            //이름 매개변수: 특성에 구현된 속성 또는 public 필드에 값을 전달할 때 사용한다.
            //다음 샘플 코드처럼 webserver 특성에 namespace 속성 값을전달
            //[WebServer(Namesapce="http://www.hawaso.com/")]


            #endregion

            #region conditional특성 사용하기
            DebugMethod();
            ReleaseMethod();
            #endregion

            #region 특성을 사용하여 메서드 호출 정보 얻기
            TraceMessage("여기에 무엇인가 실행...");
            #endregion

            //2 CustomAttrbuteTest 클래스에 적용된 특성 가져오기
            Attribute.GetCustomAttributes(typeof(CustomAttributeTest));
        }
        #region conditional특성 사용하기

        [Conditional("DEBUG")]
        static void DebugMethod() => Console.WriteLine("디버그 환경에서만 표시");

        [Conditional("RELEASE")]
        static void ReleaseMethod() => Console.WriteLine("릴리즈 환경에서만 표시");
        #endregion

        #region 특성을 사용하여 메서드 호출 정보 얻기
        public static void TraceMessage(string message,
            [CallerMemberName] string memberName ="",
            [CallerFilePath] string sourceFilePath ="",
            [CallerLineNumber] int sourceLineNumber = 0)
        {
            Console.WriteLine("실행 내용 :" + message);
            Console.WriteLine("멤버 이름 :" + memberName);
            Console.WriteLine("소스 경로 :" + sourceFilePath);
            Console.WriteLine("실행 라인 :" + sourceLineNumber);
        }
        #endregion
    }
}
