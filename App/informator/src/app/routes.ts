import { Routes } from '@angular/router'
import { HomeComponent } from './home/home.component';
import { UserComponent } from './user/user.component';
import { SignUpComponent } from './user/sign-up/sign-up.component';
import { SignInComponent } from './user/sign-in/sign-in.component';
import { AuthGuard } from './auth/auth.guard';
import { AdminPanelComponent } from './admin-panel/admin-panel.component';
import { TimetableComponent } from './timetable/timetable.component';
import { ForbiddenComponent } from './forbidden/forbidden.component';
import { MainComponent } from './main/main.component';

export const appRoutes: Routes = [
    { path: 'home', component: HomeComponent,canActivate:[AuthGuard] },
    
    { path: 'adminPanel', component: AdminPanelComponent, canActivate: [AuthGuard] , data: { roles: ['Admin'] }},
    { path: 'forbidden', component: ForbiddenComponent, canActivate: [AuthGuard] },
    { path: 'time', component: TimetableComponent },

    {
        path: 'signup', component: UserComponent,
        children: [{ path: '', component: SignUpComponent }]
    },
    {
        path: 'login', component: UserComponent,
        children: [{ path: '', component: SignInComponent }]
    },
    {
        path: 'main', component: MainComponent,
        children: [{ path: '', component: SignInComponent }]
    },
    { path : '', redirectTo:'/main', pathMatch : 'full'}
    
];