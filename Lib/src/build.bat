rem usage:
rem  "build" or "build /build" to a) checkout the files and b) build
rem  "build /rebuild" to just build (without checking the files out (again)
rem  "build /clean" to clean up from a previous build
rem Note: you should make sure there are no '.sln' files in any of the <depot>\lib\src\ec\... subfolders
rem  or when you go to build a .csproj below, it will defer to the .sln project settings, which may
rem  cause unexpected results.

set ACTION=/build
if "%1"=="/rebuild" set ACTION=/rebuild
if "%1"=="/clean" set ACTION=/clean

rem ***** Set FWROOT and BUILD_ROOT to the root of the FieldWorks project. *****
call ..\..\bin\_EnsureRoot.bat

rem Checkout the libs/dlls, etc, from Perforce so the build can overwrite them
if "%1"=="/build" call OpenLibFiles.bat %FWROOT%

rem SilEncConverters31 dependency
devenv %FWROOT%\Lib\src\EC\ECInterfaces\ECInterfaces.csproj %ACTION% Debug
devenv %FWROOT%\Lib\src\EC\ECInterfaces\ECInterfaces.csproj %ACTION% Release
devenv %FWROOT%\Lib\src\EC\EncCnvtrs\EncCnvtrs.csproj %ACTION% Debug
devenv %FWROOT%\Lib\src\EC\EncCnvtrs\EncCnvtrs.csproj %ACTION% Release

rem Other .Net-based IEncConverter implementation assemblies
devenv %FWROOT%\Lib\src\EC\AIGuesserEC\AIGuesserEC.csproj %ACTION% Debug
devenv %FWROOT%\Lib\src\EC\AIGuesserEC\AIGuesserEC.csproj %ACTION% Release
devenv %FWROOT%\Lib\src\EC\SpellingFixerEC\SpellingFixerEC.csproj %ACTION% Debug
devenv %FWROOT%\Lib\src\EC\SpellingFixerEC\SpellingFixerEC.csproj %ACTION% Release
devenv %FWROOT%\Lib\src\EC\SilIndicEncConverters\SilIndicEncConverters.csproj %ACTION% Debug
devenv %FWROOT%\Lib\src\EC\SilIndicEncConverters\SilIndicEncConverters.csproj %ACTION% Release

rem Debug COM-based IEncConverter implementations
devenv %FWROOT%\Lib\src\EC\CppEncConverterCommon\CppEncConverterCommon.vcproj %ACTION% Debug
devenv %FWROOT%\Lib\src\EC\IcuEC\IcuEC.vcproj %ACTION% Debug
devenv %FWROOT%\Lib\src\EC\PerlEC\PerlEC.vcproj %ACTION% Debug
devenv %FWROOT%\Lib\src\EC\PythonEC\PythonEC.vcproj %ACTION% Debug
devenv %FWROOT%\Lib\src\EC\ECDriver\ECDriver.vcproj %ACTION% Debug

rem Release COM-based IEncConverter implementations
devenv %FWROOT%\Lib\src\EC\CppEncConverterCommon\CppEncConverterCommon.vcproj %ACTION% Release
devenv %FWROOT%\Lib\src\EC\IcuEC\IcuEC.vcproj %ACTION% Release
devenv %FWROOT%\Lib\src\EC\PerlEC\PerlEC.vcproj %ACTION% Release
devenv %FWROOT%\Lib\src\EC\PythonEC\PythonEC.vcproj %ACTION% Release
devenv %FWROOT%\Lib\src\EC\ECDriver\ECDriver.vcproj %ACTION% Release


rem SILCnverter's clients
devenv %FWROOT%\Lib\src\EC\SILConvertersWordML\SILConvertersWordML.csproj %ACTION% Debug
devenv %FWROOT%\Lib\src\EC\DChartHelper\DChartHelper.csproj %ACTION% Debug
devenv "%FWROOT%\Lib\src\EC\TECkit Mapping Editor\TECkit Mapping Editor.csproj" %ACTION% Debug
devenv %FWROOT%\Lib\src\EC\SilConvertersXML\SilConvertersXML.csproj %ACTION% Debug
devenv %FWROOT%\Lib\src\EC\BulkSFMConverter\SFMConv.csproj %ACTION% Debug
devenv %FWROOT%\Lib\src\EC\ClipboardEC\ClipboardEC.csproj %ACTION% Debug
devenv %FWROOT%\Lib\src\EC\SILConvertersOffice\SILConvertersOffice.csproj %ACTION% Debug
devenv %FWROOT%\Lib\src\EC\SILConvertersOffice07\SILConvertersOffice07.csproj %ACTION% Debug
devenv %FWROOT%\Lib\src\EC\SILConvertersOffice10\SILConvertersOffice10.csproj %ACTION% Debug
devenv %FWROOT%\Lib\src\EC\SILConvertersInstaller\SILConvertersInstaller.vbproj %ACTION% Debug
devenv %FWROOT%\Lib\src\EC\AdaptIt2Unicode\AdaptIt2Unicode.csproj %ACTION% Debug

rem SILConverter's clients
devenv %FWROOT%\Lib\src\EC\SILConvertersWordML\SILConvertersWordML.csproj %ACTION% Release
devenv %FWROOT%\Lib\src\EC\DChartHelper\DChartHelper.csproj %ACTION% Release
devenv "%FWROOT%\Lib\src\EC\TECkit Mapping Editor\TECkit Mapping Editor.csproj" %ACTION% Release
devenv %FWROOT%\Lib\src\EC\SilConvertersXML\SilConvertersXML.csproj %ACTION% Release
devenv %FWROOT%\Lib\src\EC\BulkSFMConverter\SFMConv.csproj %ACTION% Release
devenv %FWROOT%\Lib\src\EC\ClipboardEC\ClipboardEC.csproj %ACTION% Release
devenv %FWROOT%\Lib\src\EC\SILConvertersOffice\SILConvertersOffice.csproj %ACTION% Release
devenv %FWROOT%\Lib\src\EC\SILConvertersOffice07\SILConvertersOffice07.csproj %ACTION% Release
devenv %FWROOT%\Lib\src\EC\SILConvertersOffice10\SILConvertersOffice10.csproj %ACTION% Release
devenv %FWROOT%\Lib\src\EC\SILConvertersInstaller\SILConvertersInstaller.vbproj %ACTION% Release
devenv %FWROOT%\Lib\src\EC\AdaptIt2Unicode\AdaptIt2Unicode.csproj %ACTION% Release
devenv %FWROOT%\Lib\src\EC\Installer\AppDataMover\AppDataMover.csproj %ACTION% Release

rem Merge Modules
rem GONE to WiX: devenv "%FWROOT%\Lib\src\EC\Installer\GAC MergeModule\GAC MergeModule.vdproj" %ACTION% Release
devenv %FWROOT%\Lib\src\EC\Installer\AIGuesserMM\AIGuesserMM.vdproj %ACTION% Release

rem GONE to WiX: devenv %FWROOT%\Lib\src\EC\Installer\PerlEC\PerlEC.vdproj %ACTION% Release
rem GONE to WiX: devenv %FWROOT%\Lib\src\EC\Installer\PythonEC\PythonEC.vdproj %ACTION% Release

devenv "%FWROOT%\Lib\src\EC\Installer\SCOfficeMM\SCOfficeMM.vdproj" %ACTION% Release
devenv "%FWROOT%\Lib\src\EC\Installer\SCOffice07MM\SCOffice07MM.vdproj" %ACTION% Release
devenv "%FWROOT%\Lib\src\EC\Installer\SCOffice10MM\SCOffice10MM.vdproj" %ACTION% Release

devenv "%FWROOT%\Lib\src\EC\Installer\SILConvertersForWordMM\SILConvertersForWordMM.vdproj" %ACTION% Release
devenv "%FWROOT%\Lib\src\EC\Installer\DChartHelperMM\DChartHelperMM.vdproj" %ACTION% Release
devenv "%FWROOT%\Lib\src\EC\Installer\TECkitMapUEditorMM\TECkitMapUEditor.vdproj" %ACTION% Release
devenv "%FWROOT%\Lib\src\EC\Installer\XmlConvertersMM\XmlConvertersMM.vdproj" %ACTION% Release
devenv "%FWROOT%\Lib\src\EC\Installer\SFM Converter MM\SFM Converter MM.vdproj" %ACTION% Release
devenv "%FWROOT%\Lib\src\EC\Installer\Clipboard EncConverter MM\Clipboard EncConverter MM.vdproj" %ACTION% Release
devenv "%FWROOT%\Lib\src\EC\Installer\SILConvertersOptionsInstallerMM\SILConvertersOptionsInstallerMM.vdproj" %ACTION% Release
devenv "%FWROOT%\Lib\src\EC\Installer\AdaptIt2UnicodeMM\AdaptIt2UnicodeMM.vdproj" %ACTION% Release
devenv "%FWROOT%\Lib\src\EC\Installer\SpellFixerEcMM\SpellFixerEcMM.vdproj" %ACTION% Release

rem  extra components and entity-specific packages
devenv "%FWROOT%\Lib\src\EC\Installer\TECkit DLLs\TECkit DLLs.vdproj" %ACTION% Release
devenv "%FWROOT%\Lib\src\EC\Installer\TECkit DOCs\TECkit DOCs.vdproj" %ACTION% Release
devenv "%FWROOT%\Lib\src\EC\Installer\TECkit exes\TECkit exes.vdproj" %ACTION% Release
devenv "%FWROOT%\Lib\src\EC\Installer\CC DLL MergeModule\CC DLL MergeModule.vdproj" %ACTION% Release
devenv "%FWROOT%\Lib\src\EC\Installer\DcmMM\DcmMM.vdproj" %ACTION% Release
devenv "%FWROOT%\Lib\src\EC\Installer\CscMM\CscMM.vdproj" %ACTION% Release
devenv "%FWROOT%\Lib\src\EC\Installer\SILConvertersOptionsInstallerMM\ConverterPackages\Basic Converters\Basic Converters.vdproj" %ACTION% Release
devenv "%FWROOT%\Lib\src\EC\Installer\SILConvertersOptionsInstallerMM\ConverterPackages\Cameroon\Cameroon.vdproj" %ACTION% Release
devenv "%FWROOT%\Lib\src\EC\Installer\SILConvertersOptionsInstallerMM\ConverterPackages\Central Africa\Central Africa.vdproj" %ACTION% Release
devenv "%FWROOT%\Lib\src\EC\Installer\SILConvertersOptionsInstallerMM\ConverterPackages\East Africa\East Africa.vdproj" %ACTION% Release
devenv "%FWROOT%\Lib\src\EC\Installer\SILConvertersOptionsInstallerMM\ConverterPackages\Eastern Congo Group\Eastern Congo Group.vdproj" %ACTION% Release
devenv "%FWROOT%\Lib\src\EC\Installer\SILConvertersOptionsInstallerMM\ConverterPackages\FindPhone2IPA\FindPhone2IPA.vdproj" %ACTION% Release
devenv "%FWROOT%\Lib\src\EC\Installer\SILConvertersOptionsInstallerMM\ConverterPackages\Hebrew\Hebrew.vdproj" %ACTION% Release
devenv "%FWROOT%\Lib\src\EC\Installer\SILConvertersOptionsInstallerMM\ConverterPackages\ICU Transliterators\ICU Transliterators.vdproj" %ACTION% Release
devenv "%FWROOT%\Lib\src\EC\Installer\SILConvertersOptionsInstallerMM\ConverterPackages\IndicConverters\IndicConverters.vdproj" %ACTION% Release
devenv "%FWROOT%\Lib\src\EC\Installer\SILConvertersOptionsInstallerMM\ConverterPackages\NLCI (India)\NLCI (India).vdproj" %ACTION% Release
devenv "%FWROOT%\Lib\src\EC\Installer\SILConvertersOptionsInstallerMM\ConverterPackages\PNG\PNG.vdproj" %ACTION% Release
devenv "%FWROOT%\Lib\src\EC\Installer\SILConvertersOptionsInstallerMM\ConverterPackages\SAGIndic\SAGIndic.vdproj" %ACTION% Release
devenv "%FWROOT%\Lib\src\EC\Installer\SILConvertersOptionsInstallerMM\ConverterPackages\West Africa\West Africa.vdproj" %ACTION% Release

rem revert files that haven't changed
rem p4 revert -a

echo don't forget to make sure the SpellFixer dot works and get it resigned if a change is required
