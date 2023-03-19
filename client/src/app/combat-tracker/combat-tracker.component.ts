import { Component, Input, OnInit } from "@angular/core";
import { playerCombatant } from "../_models/playerCombatant";

@Component({
	selector: "app-combat-tracker",
	templateUrl: "./combat-tracker.component.html",
	styleUrls: ["./combat-tracker.component.sass"],
})
export class CombatTrackerComponent implements OnInit {
	@Input() playerCombatants: playerCombatant[] = [];
	constructor() {}

	ngOnInit(): void {
		console.log(this.playerCombatants);
	}
}
