// Copyright Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/ObjectMacros.h"
#include "UObject/ScriptMacros.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS
#ifdef HOST_HostGameModeBase_generated_h
#error "HostGameModeBase.generated.h already included, missing '#pragma once' in HostGameModeBase.h"
#endif
#define HOST_HostGameModeBase_generated_h

#define Host_Source_Host_HostGameModeBase_h_15_SPARSE_DATA
#define Host_Source_Host_HostGameModeBase_h_15_RPC_WRAPPERS
#define Host_Source_Host_HostGameModeBase_h_15_RPC_WRAPPERS_NO_PURE_DECLS
#define Host_Source_Host_HostGameModeBase_h_15_INCLASS_NO_PURE_DECLS \
private: \
	static void StaticRegisterNativesAHostGameModeBase(); \
	friend struct Z_Construct_UClass_AHostGameModeBase_Statics; \
public: \
	DECLARE_CLASS(AHostGameModeBase, AGameModeBase, COMPILED_IN_FLAGS(0 | CLASS_Transient | CLASS_Config), CASTCLASS_None, TEXT("/Script/Host"), NO_API) \
	DECLARE_SERIALIZER(AHostGameModeBase)


#define Host_Source_Host_HostGameModeBase_h_15_INCLASS \
private: \
	static void StaticRegisterNativesAHostGameModeBase(); \
	friend struct Z_Construct_UClass_AHostGameModeBase_Statics; \
public: \
	DECLARE_CLASS(AHostGameModeBase, AGameModeBase, COMPILED_IN_FLAGS(0 | CLASS_Transient | CLASS_Config), CASTCLASS_None, TEXT("/Script/Host"), NO_API) \
	DECLARE_SERIALIZER(AHostGameModeBase)


#define Host_Source_Host_HostGameModeBase_h_15_STANDARD_CONSTRUCTORS \
	/** Standard constructor, called after all reflected properties have been initialized */ \
	NO_API AHostGameModeBase(const FObjectInitializer& ObjectInitializer = FObjectInitializer::Get()); \
	DEFINE_DEFAULT_OBJECT_INITIALIZER_CONSTRUCTOR_CALL(AHostGameModeBase) \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, AHostGameModeBase); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(AHostGameModeBase); \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API AHostGameModeBase(AHostGameModeBase&&); \
	NO_API AHostGameModeBase(const AHostGameModeBase&); \
public:


#define Host_Source_Host_HostGameModeBase_h_15_ENHANCED_CONSTRUCTORS \
	/** Standard constructor, called after all reflected properties have been initialized */ \
	NO_API AHostGameModeBase(const FObjectInitializer& ObjectInitializer = FObjectInitializer::Get()) : Super(ObjectInitializer) { }; \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API AHostGameModeBase(AHostGameModeBase&&); \
	NO_API AHostGameModeBase(const AHostGameModeBase&); \
public: \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, AHostGameModeBase); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(AHostGameModeBase); \
	DEFINE_DEFAULT_OBJECT_INITIALIZER_CONSTRUCTOR_CALL(AHostGameModeBase)


#define Host_Source_Host_HostGameModeBase_h_15_PRIVATE_PROPERTY_OFFSET
#define Host_Source_Host_HostGameModeBase_h_12_PROLOG
#define Host_Source_Host_HostGameModeBase_h_15_GENERATED_BODY_LEGACY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	Host_Source_Host_HostGameModeBase_h_15_PRIVATE_PROPERTY_OFFSET \
	Host_Source_Host_HostGameModeBase_h_15_SPARSE_DATA \
	Host_Source_Host_HostGameModeBase_h_15_RPC_WRAPPERS \
	Host_Source_Host_HostGameModeBase_h_15_INCLASS \
	Host_Source_Host_HostGameModeBase_h_15_STANDARD_CONSTRUCTORS \
public: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


#define Host_Source_Host_HostGameModeBase_h_15_GENERATED_BODY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	Host_Source_Host_HostGameModeBase_h_15_PRIVATE_PROPERTY_OFFSET \
	Host_Source_Host_HostGameModeBase_h_15_SPARSE_DATA \
	Host_Source_Host_HostGameModeBase_h_15_RPC_WRAPPERS_NO_PURE_DECLS \
	Host_Source_Host_HostGameModeBase_h_15_INCLASS_NO_PURE_DECLS \
	Host_Source_Host_HostGameModeBase_h_15_ENHANCED_CONSTRUCTORS \
private: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


template<> HOST_API UClass* StaticClass<class AHostGameModeBase>();

#undef CURRENT_FILE_ID
#define CURRENT_FILE_ID Host_Source_Host_HostGameModeBase_h


PRAGMA_ENABLE_DEPRECATION_WARNINGS
