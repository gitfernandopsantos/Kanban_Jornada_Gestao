import { Component, OnDestroy, ViewChild, ElementRef } from '@angular/core';
import { KanbanCard, Comment, ListName, Task } from '../../../../models/kanban';
import { KanbanAppComponent } from '../kanban.app.component';
import { Subscription } from 'rxjs';
import { MenuItem } from 'primeng/api';
import { KanbanService } from '../../../../services/kanban.service';

@Component({
    selector: 'app-kanban-sidebar',
    templateUrl: './kanban-sidebar.component.html',
    styleUrls: ['./kanban-sidebar.component.scss']
})
export class KanbanSidebarComponent implements OnDestroy {

    card: KanbanCard = { id: '', taskList: { title: 'Untitled Task List', tasks: [] } };

    formValue!: KanbanCard;

    listId: string = '';

    newComment: Comment = { id: '123', name: 'Jane Cooper', text: '' };

    newTask: Task = { text: '', completed: false };

    comment: string = '';

    taskContent: string = '';

    timeout: any = null;

    showTaskContainer: boolean = false;

    menuItems: MenuItem[] = [];

    listNames: ListName[] = [];

    cardSubscription: Subscription;

    listSubscription: Subscription;

    listNameSubscription: Subscription;

    @ViewChild('inputTitle') inputTitle!: ElementRef;

    @ViewChild('inputTaskListTitle') inputTaskListTitle!: ElementRef;

    constructor(public parent: KanbanAppComponent, private kanbanService: KanbanService) {

        this.cardSubscription = this.kanbanService.selectedCard$.subscribe(data => {
            this.card = data;
            this.formValue = { ...data };

        });
        this.listSubscription = this.kanbanService.selectedListId$.subscribe(data => this.listId = data);
        this.listNameSubscription = this.kanbanService.listNames$.subscribe(data => this.listNames = data);
    }

    ngOnDestroy() {
        this.cardSubscription.unsubscribe();
        this.listSubscription.unsubscribe();
        this.listNameSubscription.unsubscribe();
        clearTimeout(this.timeout);
    }

    close() {
        this.parent.sidebarVisible = false;
        this.resetForm();
    }

    onComment(event: Event) {
        event.preventDefault();
        if (this.comment.trim().length > 0) {
            this.newComment = { ...this.newComment, text: this.comment }
            this.formValue?.comments?.unshift(this.newComment);
            this.comment = '';
        }
    }

    onSave(event: any) {
        event.preventDefault();
        this.card = { ...this.formValue };
        this.kanbanService.updateCard(this.card, this.listId);
        this.close();
    }

    onMove(listId: string) {
        this.kanbanService.moveCard(this.formValue, listId, this.listId);
    }

    onDelete() {
        this.kanbanService.deleteCard(this.formValue?.id || '', this.listId);
        this.parent.sidebarVisible = false;
        this.resetForm();
    }

    resetForm() {
        this.formValue = { id: '', taskList: { title: 'Untitled Task List', tasks: [] } };
    }

    addTask(event: Event) {
        event.preventDefault();
        if (this.taskContent.trim().length > 0) {
            this.newTask = { text: this.taskContent, completed: false };
            this.formValue.taskList?.tasks.unshift(this.newTask);
            this.taskContent = '';
        }
    }

    focus(arg: number) {
        if (arg == 1) {
            this.timeout = setTimeout(() => this.inputTitle.nativeElement.focus(), 1);
        }
        if (arg == 2) {
            this.timeout = setTimeout(() => this.inputTaskListTitle.nativeElement.focus(), 1);
        }
    }

}
