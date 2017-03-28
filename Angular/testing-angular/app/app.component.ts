import { Component } from '@angular/core';

@Component({
  moduleId: module.id.replace('Jscode',''),
  selector: 'my-app',
  templateUrl: 'app.component.html'
})

export class AppComponent {
  Name: string;
  Email: string;

onSubmit(value: any)
{
  console.log(value);
}

}
