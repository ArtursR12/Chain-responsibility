using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4 // Note: actual namespace depends on the project name.
{
    interface IAuthorize
    {
        IAuthorize SetNextHandler(IAuthorize handler);

        string Execute(float sum);
   
    }
    abstract class AbsHandler : IAuthorize
    {
        private IAuthorize nextHandler;
        public AbsHandler() => nextHandler = null;
        public IAuthorize SetNextHandler(IAuthorize handler)
        {
            nextHandler = handler;
            return handler;
        }
    public virtual string Execute(float sum)
    {
        if (nextHandler != null)
            return nextHandler.Execute(sum);
        return "Noone can hanlde this ! Please enter under 100k !";
    }
}
    class ProjectManager : AbsHandler
    {
        public override string Execute(float sum)
        {
            if (sum <= 500)
                return this.GetType().Name;
            else return base.Execute(sum);
        }
    }
    class ProgramManager : AbsHandler
    {
        public override string Execute(float sum)
        {
            if (sum <= 2000)
                return this.GetType().Name;
            else return base.Execute(sum);
        }
    }
    class SubdivisionManager : AbsHandler
    {
        public override string Execute(float sum)
        {
            if (sum <= 5000)
                return this.GetType().Name;
            else return base.Execute(sum);
        }
    }
    class DivisionDirector  : AbsHandler
    {
        public override string Execute(float sum)
        {
            if (sum <= 20000)
                return this.GetType().Name;
            else return base.Execute(sum);
        }
    }
    class CEO : AbsHandler
    {
        public override string Execute(float sum)
        {
            if (sum <= 100000)
                return this.GetType().Name;
            else return base.Execute(sum);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var pm = new ProjectManager();
            var progM = new ProgramManager();
            var sm = new SubdivisionManager();
            var dd = new DivisionDirector();
            var ceo = new CEO();

            pm.SetNextHandler(progM).SetNextHandler(sm).SetNextHandler(dd).SetNextHandler(ceo);
            Console.WriteLine(pm.Execute(700));
            Console.WriteLine(pm.Execute(100));
            Console.WriteLine(pm.Execute(6700));
            Console.WriteLine(pm.Execute(12700));
            Console.WriteLine(pm.Execute(300700));
            Console.WriteLine(pm.Execute(1));
            Console.WriteLine(pm.Execute(750));

        }
    }
}