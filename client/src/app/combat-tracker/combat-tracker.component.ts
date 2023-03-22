import { AfterViewInit, Component, Input, OnChanges, OnInit, SimpleChanges } from "@angular/core";
import { playerCombatant } from "../_models/playerCombatant";

@Component({
	selector: "app-combat-tracker",
	templateUrl: "./combat-tracker.component.html",
	styleUrls: ["./combat-tracker.component.sass"],
})
export class CombatTrackerComponent implements OnChanges {
	@Input() playerCombatants: playerCombatant[] = [];
	constructor() {}

	// [debug] - delete from production
	ngOnChanges(changes: SimpleChanges): void {
		console.debug(changes);
	}

	sortCombatantsByInitiative() {
		this.playerCombatants.sort(this.dynamicSort("-initiativeBonus"));
	}

	dynamicSort(property: any) {
		var sortOrder = 1;
		if (property[0] === "-") {
			sortOrder = -1;
			property = property.substr(1);
		}
		return function (a: any, b: any) {
			/* next line works with strings and numbers,
			 * and you may want to customize it to your needs
			 */
			var result = a[property] < b[property] ? -1 : a[property] > b[property] ? 1 : 0;
			return result * sortOrder;
		};
	}
}
