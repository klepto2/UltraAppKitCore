#ifdef _ULTRA_ENGINE
	#define _ULTRA_APPKIT
#endif

#ifndef _ULTRA_APPKIT
	#ifndef _ULTRA_UTILITYKIT
		#ifndef _ULTRA_ENGINE
			#define _ULTRA_APPKIT
			#define _ULTRA_ENGINE
		#endif
	#endif
#endif

#define _ULTRA_ENGINE_VERSION 100

#ifdef _ULTRA_ENGINE
#ifndef DOUBLE_FLOAT
#ifdef _NEWTON_USE_DOUBLE
#define DOUBLE_FLOAT
#endif
#endif
#endif

using namespace std;

%include "framework.h"

%include "Enums.h"

//Math
%include "Classes/Math/Math_.h"
#ifdef _ULTRA_ENGINE
%include "Classes/Math/Math3D.h"
#else
%include "Classes/Math/Vec2.h"
%include "Classes/Math/Vec3.h"
%include "Classes/Math/Vec4.h"
%include "Classes/Math/iVec2.h"
%include "Classes/Math/iVec3.h"
%include "Classes/Math/iVec4.h"
#endif

%include "Classes/GamePad.h"

//Classes
%include "Classes/Object.h"
%include "Classes/String.h"
%include "Classes/WString.h"
%include "Classes/JSON.h"
//%include "Classes/Scripting/DynamicValue.h"
#ifdef _ULTRA_APPKIT
	%include "Classes/Display.h"
#endif
%include "Classes/IDSystem.h"

%include "Functions.h"

//Events
#ifdef _ULTRA_APPKIT
%include "Classes/GUI/Event.h"
%include "Classes/GUI/EventQueue.h"
#endif

#ifdef _ULTRA_ENGINE
%include "Classes/Workflow.h"
%include "Classes/Statistics.h"
%include "Classes/Statistics.h"
%include "Classes/MeshCollider.h"
%include "Classes/Edge.h"
%include "Classes/Face.h"
%include "Classes/ConvexHull.h"
%include "Classes/Scene.h"
%include "Classes/LegacyScene.h"
%include "Classes/Entities/Entity.h"
%include "Classes/OctreeNode.h"
%include "Classes/Culling/LightDescriptor.h"
%include "Classes/Actor.h"
%include "Classes/World.h"
%include "Classes/PickInfo.h"
%include "Classes/VirtualQuadTree.h"
#endif

%include "Classes/Language.h"
%include "Classes/FileSystem/Stream.h"
%include "Classes/FileSystem/BufferStream.h"
#ifdef _ULTRA_APPKIT
%include "Classes/FileSystem/FileSystemWatcher.h"
#endif
%include "Classes/GameEngine.h"
%include "Classes/Clock.h"
%include "Classes/Buffer.h"
#ifdef _ULTRA_ENGINE
%include "Classes/BufferPool.h"
#endif

#ifdef _ULTRA_APPKIT
//GUI
%include "Classes/GUI/Interface.h"
%include "Classes/GUI/Widget.h"
%include "Classes/GUI/Panel.h"
%include "Classes/GUI/Slider.h"
%include "Classes/GUI/Label.h"
%include "Classes/GUI/Button.h"
%include "Classes/GUI/TextField.h"
%include "Classes/GUI/TreeView.h"
%include "Classes/GUI/TextArea.h"
%include "Classes/GUI/Tabber.h"
%include "Classes/GUI/ListBox.h"
%include "Classes/GUI/ProgressBar.h"
%include "Classes/GUI/ComboBox.h"
%include "Classes/GUI/Menu.h"

%include "Classes/Window.h"
%include "Classes/Timer.h"
#endif

%include "Classes/Process.h"
%include "Classes/FileSystem/StreamBuffer.h"

//Multithreading
%include "Classes/Multithreading/Thread.h"
%include "Classes/Multithreading/Mutex.h"
#ifdef _ULTRA_ENGINE
%include "Classes/Multithreading/ThreadManager.h"
#endif

//Loaders
%include "Classes/Loaders/Loader.h"
%include "Classes/Loaders/DDSTextureLoader.h"
//%include "Classes/Loaders/SVGTextureLoader.h"
#ifdef _ULTRA_ENGINE
%include "Classes/Loaders/WAVSoundLoader.h"
%include "Classes/Loaders/TEXTextureLoader.h"
%include "Classes/Loaders/MATMaterialLoader.h"
%include "Classes/Loaders/GMFModelLoader.h"
%include "Classes/Loaders/MDLModelLoader.h"
%include "Classes/Loaders/GLTFModelLoader.h"
#endif

//Assets
%include "Classes/Assets/Asset.h"
%include "Classes/Plugin.h"
#ifdef _ULTRA_APPKIT
%include "Classes/Assets/Font.h"
#endif
#ifdef _ULTRA_ENGINE
%include "Classes/Assets/ShaderModule.h"
%include "Classes/Assets/ShaderFamily.h"
%include "Classes/Assets/Material.h"
%include "Classes/Assets/Texture.h"
%include "Classes/Assets/Material.h"
%include "Classes/Assets/ModelBase.h"
//%include "Classes/Assets/PrefabBase.h"
#endif

//File system
%include "Classes/FileSystem/Package.h"

//Graphics
%include "Classes/Graphics/Pixmap.h"
#ifdef _ULTRA_APPKIT
%include "Classes/Graphics/Icon.h"
#endif
#ifdef _ULTRA_ENGINE
%include "Classes/Graphics/Bone.h"
%include "Classes/Graphics/Shader.h"
%include "Classes/Graphics/Mesh.h"
%include "Classes/Graphics/FrameBuffer.h"
%include "Classes/Graphics/TextureBuffer.h"
%include "Classes/Graphics/Sprite.h"
%include "Classes/Graphics/Canvas.h"
%include "Classes/Graphics/Vertex.h"
%include "Classes/Graphics/LOD.h"
%include "Classes/Graphics/VoxelTree.h"
%include "Classes/Graphics/PostEffect.h"
#endif

//Scripting
#ifdef _ULTRA_ENGINE
%include "Classes/Scripting/Connection.h"
%include "Classes/Scripting/DynamicValue.h"
%include "Classes/Scripting/Coroutine.h"
#endif
#ifdef LUA_VERSION
%include "Classes/Scripting/VirtualMachine.h"
%include "Classes/Scripting/LuaBindings.h"
#endif

#ifdef _ULTRA_ENGINE
//Sound
%include "Classes/Assets/Sound.h"
%include "Classes/Sound/Speaker.h"
%include "Classes/Sound/Channel.h"

//Pathfinding
%include "Classes/Pathfinding/NavGeom.h"
%include "Classes/Pathfinding/NavMesh.h"
%include "Classes/Pathfinding/NavTile.h"
%include "Classes/Pathfinding/NavMeshDebugger.h"
%include "Classes/Pathfinding/NavAgent.h"

//Entities
%include "Classes/Entities/Pivot.h"
%include "Classes/Entities/Camera.h"
%include "Classes/Entities/Model.h"
%include "Classes/Entities/Terrain.h"
%include "Classes/Entities/Brush.h"
%include "Classes/Entities/Light.h"
%include "Classes/Entities/Listener.h"
%include "Classes/Entities/ParticleEmitter.h"
%include "Classes/Entities/StreamingTerrain.h"

//Lights
%include "Classes/Entities/SpotLight.h"
%include "Classes/Entities/PointLight.h"
%include "Classes/Entities/DirectionalLight.h"
%include "Classes/Entities/BoxLight.h"
%include "Classes/Entities/StripLight.h"

//Animation

%include "Classes/Animation/Skeleton.h"
%include "Classes/Animation/Animation.h"
%include "Classes/Animation/AnimationManager.h"
%include "Classes/Animation/AnimationThreadManager.h"
%include "Classes/Animation/AnimBone.h"
%include "Classes/Animation/AnimSkeleton.h"

//Rendering
%include "Classes/Rendering/Vulkan/GPUStructs.h"
//%include "Classes/Rendering/Vulkan/RenderInstance.h"
%include "Classes/Rendering/Vulkan/GPUDevice.h"
%include "Classes/Rendering/RenderVRSystem.h"
%include "Classes/Rendering/Vulkan/GPUCommandPool.h"
%include "Classes/Rendering/Vulkan/GPUCommandBuffer.h"
%include "Classes/Rendering/Vulkan/GPUBuffer.h"
%include "Classes/Rendering/Vulkan/RenderTexture.h"
%include "Classes/Rendering/Vulkan/SurfaceBatch.h"
%include "Classes/Rendering/Vulkan/RenderPass.h"
%include "Classes/Rendering/Vulkan/RenderPipeline.h"
%include "Classes/Rendering/Vulkan/RenderBuffer.h"
%include "Classes/Rendering/Vulkan/RenderContext.h"
%include "Classes/Rendering/Vulkan/RenderWorld.h"
%include "Classes/Rendering/Vulkan/RenderNode.h"
%include "Classes/Rendering/Vulkan/RenderSkeleton.h"
%include "Classes/Rendering/Vulkan/RenderModel.h"
%include "Classes/Rendering/Vulkan/RenderEmitter.h"
%include "Classes/Rendering/Vulkan/RenderSprite.h"
%include "Classes/Rendering/Vulkan/RenderSpriteLayer.h"
%include "Classes/Rendering/Vulkan/RenderTerrain.h"
%include "Classes/Rendering/Vulkan/RenderTerrainPatch.h"
%include "Classes/Rendering/Vulkan/RenderCamera.h"
%include "Classes/Rendering/Vulkan/RenderLight.h"
%include "Classes/Rendering/Vulkan/RenderShader.h"
%include "Classes/Rendering/Vulkan/RenderShaderModule.h"
%include "Classes/Rendering/Vulkan/RenderShaderFamily.h"
%include "Classes/Rendering/Vulkan/RenderMaterial.h"
%include "Classes/Rendering/Vulkan/ShaderBatch.h"
%include "Classes/Rendering/Vulkan/MaterialBatch.h"		
%include "Classes/Rendering/Vulkan/RenderMesh.h"
%include "Classes/Rendering/Vulkan/RenderingThreadManager.h"
%include "Classes/Rendering/Vulkan/RenderOctreeNode.h"
%include "Classes/Rendering/Vulkan/RenderQuery.h"
%include "Classes/Rendering/Vulkan/RenderImage.h"
%include "Classes/Rendering/TextureAtlas.h"
%include "Classes/Rendering/Vulkan/RenderPostEffect.h"
%include "Classes/Rendering/Vulkan/RenderVoxelTree.h"

//Culling
%include "Classes/Culling/CullingThreadManager.h"
%include "Classes/Culling/VisibilityList.h"
%include "Classes/Culling/CameraVisibilityList.h"
%include "Classes/Culling/CullingSurface.h"
%include "Classes/Culling/CullingBuffer.h"
%include "Classes/Culling/CullingContext.h"
%include "Classes/Culling/CullingMaterial.h"
%include "Classes/Culling/CullingNode.h"
%include "Classes/Culling/CullingTerrain.h"
%include "Classes/Culling/CullingModel.h"
%include "Classes/Culling/CullingCamera.h"
%include "Classes/Culling/CullingLight.h"
%include "Classes/Culling/CullingOctreeNode.h"
%include "Classes/Culling/CullingWorld.h"
%include "Classes/Culling/CullingWorld.h"
%include "Classes/Culling/SortedObject.h"
%include "Classes/Culling/CullingSpriteLayer.h"

//Physics
%include "Classes/Physics/Collision.h"
%include "Classes/Physics/Collider.h"
%include "Classes/Physics/Joint.h"
%include "Classes/Physics/Vehicle.h"
%include "Classes/Physics/PhysicsThreadManager.h"
%include "Classes/Physics/PhysicsNode.h"
%include "Classes/Physics/PhysicsPlayer.h"
%include "Classes/Physics/PhysicsParticleSystem.h"
%include "Classes/Physics/PhysicsWorld.h"
%include "Classes/Physics/PhysicsJoint.h"
%include "Classes/Physics/PhysicsShape.h"
%include "Classes/Physics/PhysicsVehicle.h"

namespace UltraEngine
{
#ifdef DOUBLE_FLOAT
	typedef double xFloat;
	typedef dVec2 xVec2;
	typedef dVec3 xVec3;
	typedef dVec4 xVec4;
	typedef dQuat xQuat;
	typedef dPlane xPlane;
	typedef dAABB xAABB;
	typedef dMat4 xMat4;
#else
	typedef float xFloat;
	typedef Vec2 xVec2;
	typedef Vec3 xVec3;
	typedef Vec4 xVec4;
	typedef Quat xQuat;
	typedef Plane xPlane;
	typedef AABB xAABB;
	typedef Mat4 xMat4;
#endif
}

#else

%include "VKFormat.h"
//%include "Libraries/Plugin SDK/FI Texture Loader//VKFormat.h"

#endif