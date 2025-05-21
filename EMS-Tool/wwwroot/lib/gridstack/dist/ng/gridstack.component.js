/**
 * gridstack.component.ts 8.0.0
 * Copyright (c) 2022 Alain Dumesny - see GridStack root license
 */
var GridstackComponent_1;
import { __decorate } from "tslib";
import { Component, ContentChildren, EventEmitter, Input, Output, ViewChild, ViewContainerRef, reflectComponentType } from '@angular/core';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';
import { GridStack } from 'gridstack';
import { GridstackItemComponent } from './gridstack-item.component';
/**
 * HTML Component Wrapper for gridstack, in combination with GridstackItemComponent for the items
 */
let GridstackComponent = GridstackComponent_1 = class GridstackComponent {
    /** initial options for creation of the grid */
    set options(val) { this._options = val; }
    /** return the current running options */
    get options() { return this._grid?.opts || this._options || {}; }
    /** return the native element that contains grid specific fields as well */
    get el() { return this.elementRef.nativeElement; }
    /** return the GridStack class */
    get grid() { return this._grid; }
    /**
     * stores the selector -> Type mapping, so we can create items dynamically from a string.
     * Unfortunately Ng doesn't provide public access to that mapping.
     */
    static { this.selectorToType = {}; }
    /** add a list of ng Component to be mapped to selector */
    static addComponentToSelectorType(typeList) {
        typeList.forEach(type => GridstackComponent_1.selectorToType[GridstackComponent_1.getSelector(type)] = type);
    }
    /** return the ng Component selector */
    static getSelector(type) {
        const mirror = reflectComponentType(type);
        return mirror.selector;
    }
    constructor(
    // private readonly zone: NgZone,
    // private readonly cd: ChangeDetectorRef,
    elementRef) {
        this.elementRef = elementRef;
        /** individual list of GridStackEvent callbacks handlers as output
         * otherwise use this.grid.on('name1 name2 name3', callback) to handle multiple at once
         * see https://github.com/gridstack/gridstack.js/blob/master/demo/events.js#L4
         *
         * Note: camel casing and 'CB' added at the end to prevent @angular-eslint/no-output-native
         * eg: 'change' would trigger the raw CustomEvent so use different name.
         */
        this.addedCB = new EventEmitter();
        this.changeCB = new EventEmitter();
        this.disableCB = new EventEmitter();
        this.dragCB = new EventEmitter();
        this.dragStartCB = new EventEmitter();
        this.dragStopCB = new EventEmitter();
        this.droppedCB = new EventEmitter();
        this.enableCB = new EventEmitter();
        this.removedCB = new EventEmitter();
        this.resizeCB = new EventEmitter();
        this.resizeStartCB = new EventEmitter();
        this.resizeStopCB = new EventEmitter();
        this.ngUnsubscribe = new Subject();
        this.el._gridComp = this;
    }
    ngOnInit() {
        // init ourself before any template children are created since we track them below anyway - no need to double create+update widgets
        this.loaded = !!this.options?.children?.length;
        this._grid = GridStack.init(this._options, this.el);
        delete this._options; // GS has it now
        this.checkEmpty();
    }
    /** wait until after all DOM is ready to init gridstack children (after angular ngFor and sub-components run first) */
    ngAfterContentInit() {
        // track whenever the children list changes and update the layout...
        this.gridstackItems?.changes
            .pipe(takeUntil(this.ngUnsubscribe))
            .subscribe(() => this.updateAll());
        // ...and do this once at least unless we loaded children already
        if (!this.loaded)
            this.updateAll();
        this.hookEvents(this.grid);
    }
    ngOnDestroy() {
        this.ngUnsubscribe.next();
        this.ngUnsubscribe.complete();
        this.grid?.destroy();
        delete this._grid;
        delete this.el._gridComp;
    }
    /**
     * called when the TEMPLATE list of items changes - get a list of nodes and
     * update the layout accordingly (which will take care of adding/removing items changed by Angular)
     */
    updateAll() {
        if (!this.grid)
            return;
        const layout = [];
        this.gridstackItems?.forEach(item => {
            layout.push(item.options);
            item.clearOptions();
        });
        this.grid.load(layout); // efficient that does diffs only
    }
    /** check if the grid is empty, if so show alternative content */
    checkEmpty() {
        if (!this.grid)
            return;
        const isEmpty = !this.grid.engine.nodes.length;
        if (isEmpty === this.isEmpty)
            return;
        this.isEmpty = isEmpty;
        // this.cd.detectChanges();
    }
    /** get all known events as easy to use Outputs for convenience */
    hookEvents(grid) {
        if (!grid)
            return;
        grid
            .on('added', (event, nodes) => { this.checkEmpty(); this.addedCB.emit({ event, nodes }); })
            .on('change', (event, nodes) => this.changeCB.emit({ event, nodes }))
            .on('disable', (event) => this.disableCB.emit({ event }))
            .on('drag', (event, el) => this.dragCB.emit({ event, el }))
            .on('dragstart', (event, el) => this.dragStartCB.emit({ event, el }))
            .on('dragstop', (event, el) => this.dragStopCB.emit({ event, el }))
            .on('dropped', (event, previousNode, newNode) => this.droppedCB.emit({ event, previousNode, newNode }))
            .on('enable', (event) => this.enableCB.emit({ event }))
            .on('removed', (event, nodes) => { this.checkEmpty(); this.removedCB.emit({ event, nodes }); })
            .on('resize', (event, el) => this.resizeCB.emit({ event, el }))
            .on('resizestart', (event, el) => this.resizeStartCB.emit({ event, el }))
            .on('resizestop', (event, el) => this.resizeStopCB.emit({ event, el }));
    }
};
__decorate([
    ContentChildren(GridstackItemComponent)
], GridstackComponent.prototype, "gridstackItems", void 0);
__decorate([
    ViewChild('container', { read: ViewContainerRef, static: true })
], GridstackComponent.prototype, "container", void 0);
__decorate([
    Input()
], GridstackComponent.prototype, "options", null);
__decorate([
    Input()
], GridstackComponent.prototype, "isEmpty", void 0);
__decorate([
    Output()
], GridstackComponent.prototype, "addedCB", void 0);
__decorate([
    Output()
], GridstackComponent.prototype, "changeCB", void 0);
__decorate([
    Output()
], GridstackComponent.prototype, "disableCB", void 0);
__decorate([
    Output()
], GridstackComponent.prototype, "dragCB", void 0);
__decorate([
    Output()
], GridstackComponent.prototype, "dragStartCB", void 0);
__decorate([
    Output()
], GridstackComponent.prototype, "dragStopCB", void 0);
__decorate([
    Output()
], GridstackComponent.prototype, "droppedCB", void 0);
__decorate([
    Output()
], GridstackComponent.prototype, "enableCB", void 0);
__decorate([
    Output()
], GridstackComponent.prototype, "removedCB", void 0);
__decorate([
    Output()
], GridstackComponent.prototype, "resizeCB", void 0);
__decorate([
    Output()
], GridstackComponent.prototype, "resizeStartCB", void 0);
__decorate([
    Output()
], GridstackComponent.prototype, "resizeStopCB", void 0);
GridstackComponent = GridstackComponent_1 = __decorate([
    Component({
        selector: 'gridstack',
        template: `
    <!-- content to show when when grid is empty, like instructions on how to add widgets -->
    <ng-content select="[empty-content]" *ngIf="isEmpty"></ng-content>
    <!-- where dynamic items go -->
    <ng-template #container></ng-template>
    <!-- where template items go -->
    <ng-content></ng-content>
  `,
        styles: [`
    :host { display: block; }
  `],
        // changeDetection: ChangeDetectionStrategy.OnPush, // IFF you want to optimize and control when ChangeDetection needs to happen...
    })
], GridstackComponent);
export { GridstackComponent };
/**
 * can be used when a new item needs to be created, which we do as a Angular component, or deleted (skip)
 **/
export function gsCreateNgComponents(host, w, add, isGrid) {
    // only care about creating ng components here...
    if (!add || !host)
        return;
    // create the component dynamically - see https://angular.io/docs/ts/latest/cookbook/dynamic-component-loader.html
    if (isGrid) {
        let grid;
        const gridItemComp = host.parentElement?._gridItemComp;
        if (gridItemComp) {
            grid = gridItemComp.container?.createComponent(GridstackComponent)?.instance;
        }
        else {
            // TODO: figure out how to create ng component inside regular Div. need to access app injectors...
            // const hostElement: Element = host;
            // const environmentInjector: EnvironmentInjector;
            // grid = createComponent(GridstackComponent, {environmentInjector, hostElement})?.instance;
        }
        if (grid)
            grid.options = w;
        return grid?.el;
    }
    else {
        const gridComp = host._gridComp;
        const gridItem = gridComp?.container?.createComponent(GridstackItemComponent)?.instance;
        // IFF we're not a subGrid, define what type of component to create as child, OR you can do it GridstackItemComponent template, but this is more generic
        const selector = w.type;
        const type = selector ? GridstackComponent.selectorToType[selector] : undefined;
        if (!w.subGridOpts && type) {
            gridItem?.container?.createComponent(type);
        }
        return gridItem?.el;
    }
}
/**
 * can be used when saving the grid - make sure we save the content from the field (not HTML as we get ng markups)
 * and can put the extra info of type, otherwise content
 */
export function gsSaveAdditionalNgInfo(n, w) {
    if (n.type)
        w.type = n.type;
    else if (n.content)
        w.content = n.content;
}
//# sourceMappingURL=gridstack.component.js.map