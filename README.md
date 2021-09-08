# MaterialDesign-DataGridExample
This small application shows differences in appeareance of the DataGrid content for MaterialDesignThemes version 4.0 and 4.1.
The MainWindow.xaml contains one DataGrid instance showing static content located in the ViewModel/MainWindowViewModel.vb class. Pressing the "ShowWindow" button in the MainWindow 
launches an AboutWindow.xaml using also an DataGrid using the same Style as in the MainWindow. Screen Shots from MainWindow as well as from MainWindow with launched AboutWindow 
are stored in the Screenshots folder.

With MaterialDesignThemes version 4.0 both Data Grids looks idenitical.

<img width="441" alt="DialogWindow_4_0" src="https://raw.githubusercontent.com/DrCQ/MaterialDesign-DataGridExample/master/DataGridExample/ScreenShots/MainWindow_4_0.PNG">

<img width="441" alt="DialogWindow_4_0" src="https://raw.githubusercontent.com/DrCQ/MaterialDesign-DataGridExample/master/DataGridExample/ScreenShots/DialogWindow_4_0.PNG">

With MaterialDesignThemes version 4.1 the DataGrid of the AboutWindow shows the first element of the DataGrid with "selected" rectange, which is wrong!

<img width="441" alt="DialogWindow_4_0" src="https://raw.githubusercontent.com/DrCQ/MaterialDesign-DataGridExample/master/DataGridExample/ScreenShots/DialogWindow_4_1.PNG">

Both DataGrids use the same Style and ControlTemplate stored in Themes/Generic.xaml file and the same ItemsSource from the ViewModel/MainWindowViewModel class.

The basic code is written in XAML. The VB code is used for creation of DataGrid content and simple command to launch the AboutWindow usng the DialogHost.

My belive is that something dealing with focus management has been changes between the version 4.0 and 4.1.
