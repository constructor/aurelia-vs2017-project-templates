import { observable } from 'aurelia-framework';
import './styles/app.css';

export class App {
  @observable message = 'Hello World!';

  constructor() {
  }

  messageChanged(newValue, oldValue) {
    // this will fire whenever the 'message' property changes
    console.log({ 'newValue': newValue, 'oldValue': oldValue });
  }
}
