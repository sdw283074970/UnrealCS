#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class APlanarReflection
	{
		static readonly int PlanarReflectionComponent__Offset;
		/// <summary>Planar reflection component.</summary>
		public UPlanarReflectionComponent PlanarReflectionComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PlanarReflectionComponent__Offset); if (v == IntPtr.Zero)return null; UPlanarReflectionComponent retValue = new UPlanarReflectionComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + PlanarReflectionComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + PlanarReflectionComponent__Offset, value._this.Get()); }
			
		}
		
		static readonly int SpriteComponent__Offset;
		public UBillboardComponent SpriteComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SpriteComponent__Offset); if (v == IntPtr.Zero)return null; UBillboardComponent retValue = new UBillboardComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bShowPreviewPlane__Offset;
		public bool bShowPreviewPlane
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowPreviewPlane__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bShowPreviewPlane__Offset, 1,0,1,255);}
			
		}
		
		static APlanarReflection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PlanarReflection");
			PlanarReflectionComponent__Offset=GetPropertyOffset(NativeClassPtr,"PlanarReflectionComponent");
			SpriteComponent__Offset=GetPropertyOffset(NativeClassPtr,"SpriteComponent");
			bShowPreviewPlane__Offset=GetPropertyOffset(NativeClassPtr,"bShowPreviewPlane");
			
		}
		
	}
	
}
#endif
#endif