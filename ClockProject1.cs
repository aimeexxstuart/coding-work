using System;
//Aimee Stuart
//project1
namespace Clock
{
    void displayTime(Clock12 userClock12, Clock24 userClock24)
    {  //displays side by side clock
        cout << "*************************\t\t" << "*************************" << endl;  //border for the clock
        cout << "*\t12-Hour Clock\t*\t\t";  //12 hour clock title
        cout << "*\t24-Hour Clock\t*" << endl;  //24 hour clock title
        cout << "*\t" << setw(2) << setfill('0') << userClock12.hours << ":" << setw(2) << setfill('0') << userClock12.minutes;  //12 hour clock display
        cout << ":" << setw(2) << setfill('0') << userClock12.seconds << " " << userClock12.meridian << "\t*\t\t";  //Continuation of previous line
        cout << "*\t" << setw(2) << setfill('0') << userClock24.hours << ":" << setw(2) << setfill('0') << userClock24.minutes;  //24 hour clock display
        cout << ":" << setw(2) << setfill('0') << userClock24.seconds << "\t*" << endl;
        cout << "*************************" << "\t\t*************************" << endl;  //border for left and right clock
    }

    void displayMenu()
    {  //Function to display menu
        cout << "\n*************************" << endl;  //top border of clock
        cout << "* 1 - Add One Hour\t*" << endl;  //user option to add 1 hour to clocks
        cout << "* 2 - Add One Minute\t*" << endl;  //user option to add 1 minute to clocks
        cout << "* 3 - Add One Second\t*" << endl;  //user option to add 1 second to clocks
        cout << "* 4 - Exit Program\t*" << endl;  //user option to exit program
        cout << "*************************" << endl;  //bottom border of clock
    }

    int main()
    {
        Clock12 clock12;  //creates 12 hour clock object
        Clock24 clock24;  //creates 24 hour clock object

        int userSelection = 0;  //takes user input for menu

        while (userSelection != 4)
        {  //loop continues until user chooses 4th option
            displayTime(clock12, clock24);  //displays clocks
            displayMenu();  //displays menu
            cin >> userSelection;  //takes users input
            switch (userSelection)
            {  //switch statement
                case 1:  //user selects add 1 hour
                    clock12.addHour(1);  //adds 1 hour to 12 hour clock
                    clock24.addHour(1);  //adds 1 hour to 24 hour clock
                    system("CLS");  //clears clock screen
                    break; //breaks the loop
                case 2:  //User selects add 1 minute
                    clock12.addMinute(1);  //adds 1 minute to 12 hour clock
                    clock24.addMinute(1);  //adds 1 minute to 24 hour clock
                    system("CLS");  //clears clock screen
                    break;  //breaks the loop
                case 3:  //user selects add 1 second
                    clock12.addSeconds(1);  //adds 1 second to 12 hour clock
                    clock24.addSeconds(1);  //adds 1 second to 24 hour clock
                    system("CLS");  //clears clock screen
                    break;  //breaks the loop
                case 4:  //user selects exit
                    cout << "Exiting Program" << endl;  //outputs exit message
                    break;  //breaks the loop
            }
        }
}
