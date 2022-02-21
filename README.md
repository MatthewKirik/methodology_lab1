# Quadratic equation solver
#### Simple .NET app for solving quadratic equations with different modes of usage

### Build
To build the app use ```dotnet-build``` command (https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-build).
Example (when in the solution root): ```dotnet build ./LAB1.sln```

### Run
To run the app in the interactive mode simply start the App.exe binary.
To run the app in the file mode start the binary with a single parameter - a path to the file with coefficients.

#### Interactive mode
This is a rather simple mode that coefficients directly from the stdin and output data to stdout.
Please, note that the input is not silent and the app will repeatingly prompt you for data. 

#### File mode
If you pass a parameter to the app, it will try to parse it as a text file with three space-separated values - a, b, and c coefficients correspondingly.
Example file ```input.txt```:
<br> ```1 4 -5```
<br>
Example program call (when in the same directory as the app and a file): ```./App.exe ./input.txt```

#### Revert commit
The task required a link to a revert commit. [Here it is](https://github.com/MatthewKirik/methodology_lab1/commit/022aadc14625f206b114aa83c629bbe635eb256a).
