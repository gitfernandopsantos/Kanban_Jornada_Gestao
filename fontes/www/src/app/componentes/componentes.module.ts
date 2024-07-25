import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

// Module Ngprime
import { MenubarModule } from 'primeng/menubar';
import { FileUploadModule } from 'primeng/fileupload';
import { TableModule } from 'primeng/table';


// Componente
import { MenubarComponent } from './menubar/menubar.component';




@NgModule({
  declarations: [
    MenubarComponent
  ],
  imports: [
    CommonModule,
    MenubarModule,
    FileUploadModule,
    TableModule,
  ],
  exports: [
    MenubarComponent
  ]
})
export class ComponentesModule { }
