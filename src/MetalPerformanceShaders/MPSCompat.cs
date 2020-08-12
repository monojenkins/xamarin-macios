#if !XAMCORE_4_0

using System;
using Metal;

using ObjCRuntime;

namespace MetalPerformanceShaders {

	public partial class MPSCnnConvolutionTransposeNode {

		[Obsolete ("Always return null (not a public API).")]
		static public MPSCnnConvolutionTransposeNode Create (MPSNNImageNode sourceNode,  MPSCnnConvolutionStateNode convolutionState, IMPSCnnConvolutionDataSource weights)
		{
			return null;
		}

		[Obsolete ("Always throw a 'NotSupportedException' (not a public API).")]
		public MPSCnnConvolutionTransposeNode (MPSNNImageNode sourceNode, MPSCnnConvolutionStateNode convolutionState, IMPSCnnConvolutionDataSource weights) : base (IntPtr.Zero)
		{
			throw new NotSupportedException ();
		}
	}

	public partial class MPSCnnConvolutionNode {

		[Obsolete ("Empty stub (not a public API).")]
		public virtual MPSCnnConvolutionStateNode ConvolutionState { get; }
	}

	public partial class MPSCnnConvolutionTranspose {
		[Obsolete ("Always throws 'NotSupportedException' (not a public API).")]
		public virtual MPSImage EncodeToCommandBuffer (IMTLCommandBuffer commandBuffer, MPSImage sourceImage, MPSCnnConvolutionState convolutionState) 
			=> throw new NotSupportedException ();
	}

	public partial class MPSCnnConvolution {
		[TV (11, 0), iOS (11, 0)]
		[Obsolete ("Always throws 'NotSupportedException' (not a public API).")]
		public virtual void EncodeToCommandBuffer (IMTLCommandBuffer commandBuffer, MPSImage sourceImage, MPSImage destinationImage, out MPSCnnConvolutionState state)
			=> throw new NotSupportedException ();
	}

	[TV (11,0), Mac (10, 13), iOS (11,0)]
	[Obsolete ("Empty stub (not a public API).")]
	public partial class MPSCnnConvolutionState : MPSState {

		[Obsolete ("Always throws 'NotSupportedException' (not a public API).")]
		[iOS (11,3), TV (11,3), Mac (10,13,4)]
		public MPSCnnConvolutionState (IMTLResource [] resources) : base (resources)
			=> throw new NotSupportedException ();

		[Obsolete ("Always throws 'NotSupportedException' (not a public API).")]
		[iOS (11,3), TV (11,3), Mac (10,13,4)]
		public MPSCnnConvolutionState (IMTLDevice device, nuint bufferSize) : base (device, bufferSize)
			=> throw new NotSupportedException ();

		[Obsolete ("Always throws 'NotSupportedException' (not a public API).")]
		[iOS (11,3), TV (11,3), Mac (10,13,4)]
		public MPSCnnConvolutionState (IMTLDevice device, MTLTextureDescriptor descriptor) : base (device, descriptor)
			=> throw new NotSupportedException ();

		[Obsolete ("Always throws 'NotSupportedException' (not a public API).")]
		[iOS (11,3), TV (11,3), Mac (10,13,4)]
		public MPSCnnConvolutionState (IMTLResource resource) : base (resource)
			=> throw new NotSupportedException ();

		[Obsolete ("Always throws 'NotSupportedException' (not a public API).")]
		[Introduced (PlatformName.MacCatalyst, 13, 0)]
		[iOS (11,3), TV (11,3), Mac (10,13,4)]
		public MPSCnnConvolutionState (IMTLDevice device, MPSStateResourceList resourceList) : base (device, resourceList)
			=> throw new NotSupportedException ();

		[Obsolete ("Empty stub (not a public API).")]
		public virtual nuint KernelWidth { get; }

		[Obsolete ("Empty stub (not a public API).")]
		public virtual nuint KernelHeight { get; }

		[Obsolete ("Empty stub (not a public API).")]
		public virtual MPSOffset SourceOffset { get; }
	}
}

#endif
