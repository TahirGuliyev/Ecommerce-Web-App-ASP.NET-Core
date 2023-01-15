import { Component } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Position } from './services/admin/alertify.service';
import { CustomToastrService, ToastrMessageType, ToastrPosition } from './services/ui/custom-toastr.service';
declare var $: any

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'EcommerceClient';
  constructor(private toastrService: CustomToastrService){
    toastrService.message("Salam", "Tahir",{ messageType: ToastrMessageType.Info, position: ToastrPosition.TopCenter });
    toastrService.message("Salam", "Tahir",{ messageType: ToastrMessageType.Info, position: ToastrPosition.TopLeft });
    toastrService.message("Salam", "Tahir",{ messageType: ToastrMessageType.Info, position: ToastrPosition.TopRight });
    toastrService.message("Salam", "Tahir",{ messageType: ToastrMessageType.Info, position: ToastrPosition.BottomFullWidth });
  }
}
