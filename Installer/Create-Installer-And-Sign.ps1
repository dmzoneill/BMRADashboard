Write-Host "Generating installer"
& "C:\Program Files (x86)\Inno Setup 5\iscc.exe" setup.iss
$idsid = Read-Host 'Please input windows ID [dmoneil2]'
$pass = Read-Host 'Please input password for signing' -AsSecureString
$pass = [Runtime.InteropServices.Marshal]::PtrToStringAuto([Runtime.InteropServices.Marshal]::SecureStringToBSTR($pass))

$ProcessInfo = New-Object System.Diagnostics.ProcessStartInfo 
$ProcessInfo.FileName = "signfile.exe" 
$ProcessInfo.RedirectStandardError = $true 
$ProcessInfo.RedirectStandardOutput = $true 
$ProcessInfo.UseShellExecute = $false 
$ProcessInfo.Arguments = "-u ger\$idsid -p $pass -vv Output\BMRA-Dashboard-Setup.exe" 
$Process = New-Object System.Diagnostics.Process 
$Process.StartInfo = $ProcessInfo 
$Process.Start() | Out-Null 
$Process.WaitForExit() 
$output = $Process.StandardOutput.ReadToEnd() 
# uncomment for debug
# $output 

Write-Host "You should confirm signing was sucecssfull"
Write-Host "Uncomment the line above this one for debug"

exit