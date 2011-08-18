using System;
using System.Collections.Generic;
using System.Text;

namespace Canguro.Commands.View
{
    /// <summary>
    /// View Command to show the Moment around 33 axis component of the internal forces in elements.
    /// </summary>
    public class RenderM3 : Canguro.Commands.ViewCommand
    {
        private RenderM3() { }
        public static RenderM3 Instance = new RenderM3();

        /// <summary>
        /// This command is not interactive. Returns false.
        /// </summary>
        public override bool IsInteractive
        {
            get { return false; }
        }

        /// <summary>
        /// Executes the Non-Interactive Command.
        /// Sets the InternalForcesShown property of RenderOptions to Mz
        /// </summary>
        /// <param name="activeView">The Current Active View object</param>
        public override void  Run(Canguro.View.GraphicView activeView)
        {
            Canguro.View.Renderer.ModelRenderer mr = activeView.ModelRenderer;
            if (mr != null && mr.ForcesRenderer != null)
            {
                if (mr.RenderOptions.InternalForcesShown == Canguro.View.Renderer.RenderOptions.InternalForces.Mz)
                    mr.RenderOptions.InternalForcesShown = Canguro.View.Renderer.RenderOptions.InternalForces.None;
                else
                    mr.RenderOptions.InternalForcesShown = Canguro.View.Renderer.RenderOptions.InternalForces.Mz;
            }
        }
    }
}
