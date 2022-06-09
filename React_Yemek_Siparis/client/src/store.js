import { applyMiddleware, combineReducers, createStore } from "redux";
import thunk from "redux-thunk";
import { composeWithDevTools } from "redux-devtools-extension";
import { getAllFoodsReducer } from "./reducers/foodReducers";

const finalReducer = combineReducers({
  getAllFoodsReducer: getAllFoodsReducer,
});

const initialState = {};

const composeEnhacers = composeWithDevTools({});

const store = createStore(
  finalReducer,
  initialState,
  composeEnhacers(applyMiddleware(thunk))
);

export default store;
