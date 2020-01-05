#!/bin/bash
dotnet aspnet-codegenerator controller \
	-name GuestController \
	-m Guest -dc GuestbookGuestContext \
	--relativeFolderPath Controllers \
	--useDefaultLayout -f \
	--referenceScriptLibraries
