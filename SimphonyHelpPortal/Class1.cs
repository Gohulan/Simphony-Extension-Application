using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Micros.Ops;
using Micros.Ops.Extensibility;
using Micros.PosCore.Extensibility;
using Micros.PosCore.Extensibility.Ops;

//namespace SimphonyHelpPortal
namespace MyExtensionApplication
{

    /// <summary>
    /// Implements the extension application
    /// </summary>
    public class Application : OpsExtensibilityApplication
    {
        /// <summary>
        /// Extension application constructor
        /// </summary>
        /// <param name="context">the execution context for the application</param>
        public Application(IExecutionContext context)
            : base(context)
        {
            // TODO: Add initialization code and hook up event handlers here
        }

        [ExtensibilityMethod]
        public void MyExtensionMethod()
        {
            // TODO: rename method and implement
            OpsContext.ShowMessage(string.Format("Hello World from {0}", this.ApplicationName));
        }
    }

    /// <summary>
    ///  Implements interface used by Simphony POS Client to create an instance of the extension application
    /// </summary>
    public class ApplicationFactory : IExtensibilityAssemblyFactory
    {
        public ExtensibilityAssemblyBase Create(IExecutionContext context)
        {
            return new Application(context);
        }

        public void Destroy(ExtensibilityAssemblyBase app)
        {
            app.Destroy();
        }
    }
}