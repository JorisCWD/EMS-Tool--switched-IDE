/**
 * gridstack-item.component.ts 8.0.0
 * Copyright (c) 2022 Alain Dumesny - see GridStack root license
 */
import { __decorate } from "tslib";
import { Component, Input, ViewChild, ViewContainerRef } from '@angular/core';
/**
 * HTML Component Wrapper for gridstack items, in combination with GridstackComponent for parent grid
 */
let GridstackItemComponent = class GridstackItemComponent {
    /** list of options for creating/updating this item */
    set options(val) {
        if (this.el.gridstackNode?.grid) {
            // already built, do an update...
            this.el.gridstackNode.grid.update(this.el, val);
        }
        else {
            // store our custom element in options so we can update it and not re-create a generic div!
            this._options = { ...val, el: this.el };
        }
    }
    /** return the latest grid options (from GS once built, otherwise initial values) */
    get options() {
        return this.el.gridstackNode || this._options || { el: this.el };
    }
    /** return the native element that contains grid specific fields as well */
    get el() { return this.elementRef.nativeElement; }
    /** clears the initial options now that we've built */
    clearOptions() {
        delete this._options;
    }
    constructor(elementRef) {
        this.elementRef = elementRef;
        this.el._gridItemComp = this;
    }
    ngOnDestroy() {
        delete this.el._gridItemComp;
    }
};
__decorate([
    ViewChild('container', { read: ViewContainerRef, static: true })
], GridstackItemComponent.prototype, "container", void 0);
__decorate([
    Input()
], GridstackItemComponent.prototype, "options", null);
GridstackItemComponent = __decorate([
    Component({
        selector: 'gridstack-item',
        template: `
    <div class="grid-stack-item-content">
      <!-- where dynamic items go based on component types, or sub-grids, etc...) -->
      <ng-template #container></ng-template>
      <!-- any static (defined in dom) content goes here -->
      <ng-content></ng-content>
      <!-- fallback HTML content from GridStackWidget content field if used instead -->
      {{options.content}}
    </div>`,
        styles: [`
    :host { display: block; }
  `],
        // changeDetection: ChangeDetectionStrategy.OnPush, // IFF you want to optimize and control when ChangeDetection needs to happen...
    })
], GridstackItemComponent);
export { GridstackItemComponent };
//# sourceMappingURL=gridstack-item.component.js.map