using System;
namespace UnrealEngine
{
	public partial class UDecalComponent:USceneComponent
	{
		/// <summary>Utility to allocate a new Dynamic Material Instance, set its parent to the currently applied material, and assign it</summary>
		public extern virtual UMaterialInstanceDynamic CreateDynamicMaterialInstance();
		/// <summary>Accessor for decal material</summary>
		public extern UMaterialInterface GetDecalMaterial();
		/// <summary>setting decal material on decal component. This will force the decal to reattach</summary>
		public extern void SetDecalMaterial(UMaterialInterface NewDecalMaterial);
		/// <summary>Sets the sort order for the decal component. Higher values draw later (on top). This will force the decal to reattach</summary>
		public extern void SetSortOrder(int Value);
		/// <summary>
		/// Sets the decal's fade start time, duration and if the owning actor should be destroyed after the decal is fully faded out.
		/// The default value of 0 for FadeStartDelay and FadeDuration makes the decal persistent. See DecalLifetimeOpacity material
		/// node to control the look of "fading out."
		/// @param StartDelay - Time in seconds to wait before beginning to fade out the decal.
		/// @param Duration - Time in second for the decal to fade out.
		/// @param DestroyOwnerAfterFade - Should the owning actor automatically be destroyed after it is completely faded out.
		/// </summary>
		public extern void SetFadeOut(float StartDelay,float Duration,bool DestroyOwnerAfterFade=true);
		public extern float GetFadeDuration();
		public extern float GetFadeStartDelay();
		/// <summary>Decal material.</summary>
		public UMaterialInterface DecalMaterial;
		
		/// <summary>
		/// Controls the order in which decal elements are rendered.  Higher values draw later (on top).
		/// Setting many different sort orders on many different decals prevents sorting by state and can reduce performance.
		/// </summary>
		public int SortOrder;
		
		public float FadeScreenSize;
		
		/// <summary>Time in seconds to wait before beginning to fade out the decal. Set fade duration and start delay to 0 to make persistent.</summary>
		public float FadeStartDelay;
		
		/// <summary>Time in seconds for the decal to fade out. Set fade duration and start delay to 0 to make persistent.</summary>
		public float FadeDuration;
		
		/// <summary>Automatically destroys the owning actor after fully fading out.</summary>
		public bool bDestroyOwnerAfterFade;
		
		/// <summary>Decal size in local space (does not include the component scale), technically redundant but there for convenience</summary>
		public FVector DecalSize;
		
		
	}
	
}
