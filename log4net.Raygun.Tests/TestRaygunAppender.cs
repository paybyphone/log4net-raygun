﻿using System.Threading.Tasks;
using log4net.Raygun.Core;

namespace log4net.Raygun.Tests
{
    public class TestRaygunAppender : RaygunAppenderBase
    {
        public TestRaygunAppender(IUserCustomDataBuilder userCustomDataBuilder, IRaygunMessageBuilder raygunMessageBuilder,
                                  IRaygunClientFactory raygunClientFactory, ITypeActivator typeActivator, TaskScheduler taskScheduler)
            : base(userCustomDataBuilder, raygunMessageBuilder, raygunClientFactory, typeActivator, taskScheduler)
        {
        }
    }
}