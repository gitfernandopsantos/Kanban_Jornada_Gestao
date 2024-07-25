import { Component, OnInit } from '@angular/core';
import { MenuItem } from 'primeng/api';


@Component({
  selector: 'app-menubar',
  templateUrl: '../menubar/menubar.component.html',
  styleUrls: ['../menubar/menubar.component.css']
})
export class MenubarComponent {
  items: MenuItem[] | undefined;

  ngOnInit() {
    this.items = [
      {
        label: 'Inicio',
        icon: 'pi pi-fw pi-home',
        routerLink: '/inicio',
      },
      {
        label: 'Kanban',
        icon: 'pi pi-fw pi-th-large',
        routerLink: '/kanban',
      }
    ];
  }
}
