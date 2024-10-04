#include "list.h"
#include <vector>
using listmanager::ToDoList;

// Default constructor, new instances having an incrementing identification number.
int ToDoList::next_manager_id = 0;
ToDoList::ToDoList() : list_manager_id{ next_manager_id++ } {}

void ToDoList::set_manager_name(string list_manager_name) {
	this->list_manager_name = list_manager_name;
}

void ToDoList::set_list_name(string list_name) {
	this->list_name = list_name;
}

int ToDoList::get_manager_id(void)const {
	return this->list_manager_id;
}

string ToDoList::get_manager_name(void)const {
	return this->list_manager_name;
}

string ToDoList::get_list_name(void)const {
	return this->list_name;
}

vector<string> ToDoList::get_list_tasks(void)const {
	return this->list_tasks;
}

void ToDoList::add_list_task(string list_task) {
	this->list_tasks.emplace_back(list_task);
}

void ToDoList::remove_list_task(int task_index) {
	this->list_tasks.erase(this->list_tasks.begin() + task_index);
}

void ToDoList::display_list() {
	int x = 0;
	for (int i = 0; i < this->list_tasks.size(); i++) {
		cout << "[" << x++ << "] " << this->list_tasks[i] << "\n";
	}
}