using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception //Aspect methodun başında sonunda hata verdiğinde çalısacak yapı
    {
        private Type _validatorType;
        //attribute olduğu için type tipi
        public ValidationAspect(Type validatorType)
        {
            //defensive coding gelen type is assignable mi başka classlar gönderilmesin diye alınan önlem
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Dogrulama sinifi degil !");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            //reflection-> çalışma anında çalıştırıyor, instance oluştur
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            //invocation method demek methodun parametrelerine bak
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
