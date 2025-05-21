/**
 * gridstack-item.component.ts 8.0.0
 * Copyright (c) 2022 Alain Dumesny - see GridStack root license
 */
import { ElementRef, ViewContainerRef, OnDestroy } from '@angular/core';
import { GridItemHTMLElement, GridStackNode } from 'gridstack';
/** store element to Ng Class pointer back */
export interface GridItemCompHTMLElement extends GridItemHTMLElement {
    _gridItemComp?: GridstackItemComponent;
}
/**
 * HTML Component Wrapper for gridstack items, in combination with GridstackComponent for parent grid
 */
export declare class GridstackItemComponent implements OnDestroy {
    private readonly elementRef;
    /** container to append items dynamically */
    container?: ViewContainerRef;
    /** list of options for creating/updating this item */
    set options(val: GridStackNode);
    /** return the latest grid options (from GS once built, otherwise initial values) */
    get options(): GridStackNode;
    private _options?;
    /** return the native element that contains grid specific fields as well */
    get el(): GridItemCompHTMLElement;
    /** clears the initial options now that we've built */
    clearOptions(): void;
    constructor(elementRef: ElementRef<GridItemHTMLElement>);
    ngOnDestroy(): void;
}
