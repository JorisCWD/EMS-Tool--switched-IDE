/**
 * gridstack.component.ts 8.0.0
 * Copyright (c) 2022 Alain Dumesny - see GridStack root license
 */
import { AfterContentInit, ElementRef, EventEmitter, OnDestroy, OnInit, QueryList, Type, ViewContainerRef } from '@angular/core';
import { GridHTMLElement, GridItemHTMLElement, GridStack, GridStackNode, GridStackOptions, GridStackWidget } from 'gridstack';
import { GridstackItemComponent } from './gridstack-item.component';
/** events handlers emitters signature for different events */
export type eventCB = {
    event: Event;
};
export type elementCB = {
    event: Event;
    el: GridItemHTMLElement;
};
export type nodesCB = {
    event: Event;
    nodes: GridStackNode[];
};
export type droppedCB = {
    event: Event;
    previousNode: GridStackNode;
    newNode: GridStackNode;
};
/** extends to store Ng Component selector, instead/inAddition to content */
export interface NgGridStackWidget extends GridStackWidget {
    type?: string;
}
export interface NgGridStackNode extends GridStackNode {
    type?: string;
}
export interface NgGridStackOptions extends GridStackOptions {
    children?: NgGridStackWidget[];
    subGridOpts?: NgGridStackOptions;
}
/** store element to Ng Class pointer back */
export interface GridCompHTMLElement extends GridHTMLElement {
    _gridComp?: GridstackComponent;
}
/** selector string to runtime Type mapping */
export type SelectorToType = {
    [key: string]: Type<Object>;
};
/**
 * HTML Component Wrapper for gridstack, in combination with GridstackItemComponent for the items
 */
export declare class GridstackComponent implements OnInit, AfterContentInit, OnDestroy {
    private readonly elementRef;
    /** track list of TEMPLATE grid items so we can sync between DOM and GS internals */
    gridstackItems?: QueryList<GridstackItemComponent>;
    /** container to append items dynamically */
    container?: ViewContainerRef;
    /** initial options for creation of the grid */
    set options(val: GridStackOptions);
    /** return the current running options */
    get options(): GridStackOptions;
    /** true while ng-content with 'no-item-content' should be shown when last item is removed from a grid */
    isEmpty?: boolean;
    /** individual list of GridStackEvent callbacks handlers as output
     * otherwise use this.grid.on('name1 name2 name3', callback) to handle multiple at once
     * see https://github.com/gridstack/gridstack.js/blob/master/demo/events.js#L4
     *
     * Note: camel casing and 'CB' added at the end to prevent @angular-eslint/no-output-native
     * eg: 'change' would trigger the raw CustomEvent so use different name.
     */
    addedCB: EventEmitter<nodesCB>;
    changeCB: EventEmitter<nodesCB>;
    disableCB: EventEmitter<eventCB>;
    dragCB: EventEmitter<elementCB>;
    dragStartCB: EventEmitter<elementCB>;
    dragStopCB: EventEmitter<elementCB>;
    droppedCB: EventEmitter<droppedCB>;
    enableCB: EventEmitter<eventCB>;
    removedCB: EventEmitter<nodesCB>;
    resizeCB: EventEmitter<elementCB>;
    resizeStartCB: EventEmitter<elementCB>;
    resizeStopCB: EventEmitter<elementCB>;
    /** return the native element that contains grid specific fields as well */
    get el(): GridCompHTMLElement;
    /** return the GridStack class */
    get grid(): GridStack | undefined;
    /**
     * stores the selector -> Type mapping, so we can create items dynamically from a string.
     * Unfortunately Ng doesn't provide public access to that mapping.
     */
    static selectorToType: SelectorToType;
    /** add a list of ng Component to be mapped to selector */
    static addComponentToSelectorType(typeList: Array<Type<Object>>): void;
    /** return the ng Component selector */
    static getSelector(type: Type<Object>): string;
    private _options?;
    private _grid?;
    private loaded?;
    private ngUnsubscribe;
    constructor(elementRef: ElementRef<GridCompHTMLElement>);
    ngOnInit(): void;
    /** wait until after all DOM is ready to init gridstack children (after angular ngFor and sub-components run first) */
    ngAfterContentInit(): void;
    ngOnDestroy(): void;
    /**
     * called when the TEMPLATE list of items changes - get a list of nodes and
     * update the layout accordingly (which will take care of adding/removing items changed by Angular)
     */
    updateAll(): void;
    /** check if the grid is empty, if so show alternative content */
    checkEmpty(): void;
    /** get all known events as easy to use Outputs for convenience */
    private hookEvents;
}
/**
 * can be used when a new item needs to be created, which we do as a Angular component, or deleted (skip)
 **/
export declare function gsCreateNgComponents(host: GridCompHTMLElement | HTMLElement, w: NgGridStackWidget | GridStackOptions, add: boolean, isGrid: boolean): HTMLElement | undefined;
/**
 * can be used when saving the grid - make sure we save the content from the field (not HTML as we get ng markups)
 * and can put the extra info of type, otherwise content
 */
export declare function gsSaveAdditionalNgInfo(n: NgGridStackNode, w: NgGridStackWidget): void;
