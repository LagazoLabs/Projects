// To-Do List Manager: Allow users to add, remove, and view tasks.
#include "list.h"
#include <vector>
#include <string>
#include <iostream>
using listmanager::ToDoList;
using namespace std;

int main()
{
    int option = -1;
    char option2;

    ToDoList account_1;
    string i_manager_name;
    string i_list_name;
    string i_list_task;
    int i_list_index;
    bool adding;
    bool removing;

    cout << "To-Do-List Manager\n";

    cout << "\nList Manager Name: ";
    std::cin.ignore();
    std::getline(std::cin, i_manager_name);
    account_1.set_manager_name(i_manager_name);

    cout << "\nList Name: ";
    std::cin.ignore();
    std::getline(std::cin, i_list_name);
    account_1.set_list_name(i_list_name);

    while (option != 0) {
        cout << "\nList Manager Menu\n";

        cout << "[0] Exit Program\n";
        cout << "[1] Display Information\n";
        cout << "[2] Add List Task\n";
        cout << "[3] Remove List Task\n";
        cout << "[4] Update Manager Name\n";
        cout << "[5] Update List Name\n";

        cout << "\nOption: ";
        cin >> option;

        //std::cin.ignore();
        switch (option) {
            case 0:
                break;
            case 1:
                cout << "List Name: " << account_1.get_list_name() << "\n";
                cout << "List Manager: " << account_1.get_manager_name() << "\n";
                cout << "List Task: \n";
                account_1.display_list();
                break;
            case 2:
                adding = true;
                option2 = 'Y';
                while (adding) {
                    if (option2 == 'N' or option2 == 'n') {
                        adding = false;
                    }
                    else {
                        std::cout << "\nTask: ";
                        std::cin.ignore();
                        std::getline(std::cin, i_list_task);
                        account_1.add_list_task(i_list_task);
                        cout << "\nContinue? (Y/N): ";
                        cin >> option2;
                    }
                }
                break;
            case 3:
                removing = true;
                option2 = 'Y';
                while (removing) {

                    cout << "\nList Task: \n";
                    account_1.display_list();

                    if (option2 == 'N' or option2 == 'n') {
                        removing = false;
                    }
                    else {
                        cout << "\nList Index: ";
                        cin >> i_list_index;
                        account_1.remove_list_task(i_list_index);
                        cout << "\nContinue? (Y/N): ";
                        cin >> option2;
                    }
                }
                break;
            case 4:
                cout << "List Manager Name: ";
                std::cin.ignore();
                std::getline(std::cin, i_manager_name);
                account_1.set_manager_name(i_manager_name);
                break;
            case 5:
                cout << "\nList Name: ";
                std::cin.ignore();
                std::getline(std::cin, i_list_name);
                account_1.set_list_name(i_list_name);
                break;
        }
    }
}