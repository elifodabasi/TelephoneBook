using Autofac;
using Business.PersonOps;
using DataAccess.EntityFramework.PersonDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            #region DataAccessLayers
            builder.RegisterType<EfPersonDal>().As<IPersonDal>().SingleInstance();
            #endregion

            #region BusinessLayer
            builder.RegisterType<PersonService>().As<IPersonService>().SingleInstance();

            #endregion
        }
    }
}
