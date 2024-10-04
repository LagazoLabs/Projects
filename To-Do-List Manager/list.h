using namespace std;
#include <iostream>
#include <string>
#include <vector>

#pragma once
#define list_h

namespace listmanager {
    class ToDoList {
    private:
        static int next_manager_id;
        int list_manager_id;
        string list_manager_name;
        string list_name;
        std::vector<string> list_tasks;
    public:
        // blank constructor
        ToDoList();
        // setter methods
        void set_manager_name(string list_manager_name);
        void set_list_name(string list_name);

        // getter methods
        int get_manager_id(void)const;
        string get_manager_name(void)const;
        string get_list_name(void)const;
        vector<string> get_list_tasks(void)const;
        // other methods
        void add_list_task(string list_task);
        void remove_list_task(int task_index);
        void display_list();
    };
}