﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuggeBook.Dto.Mocks
{
    public static class SuggeBookDto_Mocks_Injection
    {
        public static void Add_MocksServices (this IServiceCollection services)
        {
            services.AddTransient<IFakeAuthorService, FakeAuthorService>();
            services.AddTransient<IFakeBooksService, FakeBooksService>();
            services.AddTransient<IFakeSuggestionsService, FakeSuggestionsService>();
            services.AddTransient<IFakeUserService, FakeUserService>();
            services.AddTransient<ITestsBank, TestsBank>();
        }
    }
}
