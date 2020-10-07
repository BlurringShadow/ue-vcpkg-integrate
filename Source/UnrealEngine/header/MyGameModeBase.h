#pragma once

#include <CoreMinimal.h>
#include <GameFramework/GameModeBase.h>

// Third party
#include <third_include_start.h>

#include <boost/date_time.hpp>
#include <fmt/format.h>

// ReSharper disable once CppWrongIncludesOrder
#include <third_include_end.h>

#include "MyGameModeBase.generated.h"

UCLASS()
class UNREALENGINE_API AMyGameModeBase final : public AGameModeBase
{
	GENERATED_BODY()

	void StartPlay() override;
};
