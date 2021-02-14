using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MyJetWallet.Sdk.Postgres;
using WebApplication9.Db;

namespace WebApplication9.DesignTime
{
    public class ContextFactory : MyDesignTimeContextFactory<MyContext>
    {
        public ContextFactory() : base(options => new MyContext(options))
        {
        }
    }
}
