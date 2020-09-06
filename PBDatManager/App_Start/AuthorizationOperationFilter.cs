using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Description;

namespace PBDatManager.App_Start
{
    public class AuthorizationOperationFilter : IOperationFilter
    {
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            if(operation.parameters != null)
            {
                //operation.parameters = new List<Parameter>();

                operation.parameters.Add(new Parameter
                {
                    name = "Authorization",
                    @in = "header",
                    description = "access token",
                    required = false,
                    type = "string",
                    @default = "Bearer rGDzRPdcZsVzJUKwJMcK-iOYA6nOZAMxwBAXklHB3JelZk4H2UrO9n0ZOvcFsTJToW1CQKHoJsb5FAL8ObpO2tOF8TuV3SbRYfGz1i7LV1xAvSFqOcnw8nxeD13nzqa-uKJcvX9iM8QuPYd0NtHEHu7QwuM4aB-Jx7cQO2zNPu2o98EKBP6Hh03YzgRi1jYiE6oVYEMWHKp7dQmyWA0IcEe_-ppCKhiyaWKrGAgc9Tgu8eDSF9CK0iYddiIETXvXIQp7UdO52dLDeWcToFezodgh_rhXfvn_QsPq2duzI1TFn_q0nRo-rzfFImIDr5J6YYwFqcBOfhSlEjITgOYa9FIFuq6jHsJDs8lE7cdL5yfy2Qj-2iC7SvdaiUvGy5MeCvHhFzAmNmAsxs8gnKYVV6nNyRioxeBhJab8mkTcfZhDZI4-s6OL7ScAHc0OVvz-Hg1mT_ITH9CSuKZQAUJ_MY_Kxt8zjx3MvF2bp74LIr8"
                });
            }
        }
    }
}