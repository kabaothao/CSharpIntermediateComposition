using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateComposition
{
    private readonly Logger _logger;
    public class DbMigrator(Logger logger)
    {
        _logger = logger;

    }


    public void Migrate()


}
