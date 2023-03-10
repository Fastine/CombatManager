import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";

@Component({
	selector: "app-root",
	templateUrl: "./app.component.html",
	styleUrls: ["./app.component.sass"],
})
export class AppComponent implements OnInit {
	title = "D&D 5e Combat Manager";
	playerCombatants: any;

	constructor(private http: HttpClient) {}

	ngOnInit(): void {
		this.http.get("https://localhost:7206/api/PlayerCombatants").subscribe({
			next: response => (this.playerCombatants = response),
			error: error => console.log(error),
			complete: () => console.log("Request has completed"),
		});
	}
}
