var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
import { observable } from 'aurelia-framework';
import './styles/app.css';
var App = /** @class */ (function () {
    function App() {
        this.message = 'Hello World!';
    }
    App.prototype.messageChanged = function (newValue, oldValue) {
        // this will fire whenever the 'message' property changes
        console.log({ 'newValue': newValue, 'oldValue': oldValue });
    };
    __decorate([
        observable,
        __metadata("design:type", Object)
    ], App.prototype, "message", void 0);
    return App;
}());
export { App };
//# sourceMappingURL=app.js.map