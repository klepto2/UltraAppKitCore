$inifile = get-content "settings.ini"

[string]$resultxml="<inifile>"
[string]$inisection=""
foreach ($line in $inifile) {
   if ($line[0] -eq "[") {
      if ($inisection -ne "") {
         $resultxml+=("</$inisection>`r`n")
      }
      $inisection = $line.replace("[","").replace("]","")
      $resultxml+=("<$inisection>`r`n")
   }
   elseif ($line -like "*=*") {
      $key=($line.split("=")[0])
      $value=($line.split("=")[1])
      $resultxml+=("<$key>$value</$key>`r`n")
   }
}
$resultxml+=("</$inisection>`r`n")
$resultxml+="</inifile>"
[xml]$inixml = $resultxml

[string]$ultrappkitPath = $inixml.inifile.config.ultraappkit
$include
Remove-Item "Projects\C#\Generated\*.cs"
Start-Process -NoNewWindow -Wait -FilePath ".\SWIG\swig.exe" -ArgumentList "-help"
Start-Process -NoNewWindow -Wait -FilePath ".\SWIG\swig.exe" -ArgumentList "-Fmicrosoft", "-v","-namespace  `"UltraEngine`"", "-csharp","-c++","-v", "-outdir `"Projects\C#\Generated`"", "-o `"Projects\C++\Source\main.cpp`"","-D_WIN32", "-D_ULTRA_APPKIT","-cpperraswarn", "-ignoremissing", "-I`"$ultrappkitPath`"\Include", "Interface/UltraAppKit.i"

$Source = '.DllImport("Functions"'
$Target = ,'.DllImport(WrapperConstants.DllPath'
$filePath = "Projects\C#\Generated\PINVOKE.cs"
(Get-Content $filePath).Replace($Source,$Target) | Set-Content $filePath

Write-Host "Ready..."