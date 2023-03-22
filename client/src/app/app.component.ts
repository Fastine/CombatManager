import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { playerCombatant } from "./_models/playerCombatant";

@Component({
	selector: "app-root",
	templateUrl: "./app.component.html",
	styleUrls: ["./app.component.sass"],
})
export class AppComponent implements OnInit {
	title = "D&D 5e Combat Manager";
	playerCombatants: playerCombatant[] = [];

	constructor(private http: HttpClient) {
		this.http.get<playerCombatant[]>("https://localhost:7206/api/PlayerCombatants").subscribe({
			next: response => (this.playerCombatants = [...response]),
			error: error => console.log(error),
			complete: () => console.log("Request has completed" + [...this.playerCombatants]),
		});
	}

	ngOnInit(): void {}
}
