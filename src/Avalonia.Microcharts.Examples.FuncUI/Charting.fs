namespace Avalonia.Microcharts.Examples.FuncUI

open Avalonia.FuncUI.Builder
open Avalonia.FuncUI.Types
open Avalonia.Microcharts
open SkiaSharp

[<AutoOpen>]
module Binding =
    module MicrochartControl =

        let create (attrs: IAttr<MicrochartControl> list) : IView<MicrochartControl> =
            ViewBuilder.Create<MicrochartControl>(attrs)

    type MicrochartControl with
        static member chart<'t when 't :> MicrochartControl>(value: Chart) : IAttr<'t> =
            let getter : ('t -> Chart) = (fun control -> control.Chart)
            let setter : ('t * Chart -> unit) = (fun (control, value) -> control.Chart <- value)

            AttrBuilder<'t>.CreateProperty<Chart>("Chart", value, ValueSome getter, ValueSome setter, ValueNone)

module Charting =
    open Avalonia.Controls
    open Avalonia.FuncUI.DSL
    open Avalonia.Layout

    type State = { count : int }
    let init = { count = 0 }

    type Msg = Increment | Decrement | Reset

    let update (msg: Msg) (state: State) : State =
        match msg with
        | Increment -> { state with count = state.count + 1 }
        | Decrement -> { state with count = state.count - 1 }
        | Reset -> init

    let view (state: State) (dispatch) =
        DockPanel.create [
            DockPanel.children [
                Button.create [
                    Button.dock Dock.Bottom
                    Button.onClick (fun _ -> dispatch Reset)
                    Button.content "add random data point"
                ]
                MicrochartControl.create [
                    MicrochartControl.dock Dock.Top
                    MicrochartControl.chart (
                        let entries = [|
                            Entry (
                                Value = 200.0f,
                                Label = "Jan",
                                ValueLabel = "200",
                                Color = SKColor.Parse("#266489")
                            )
                            Entry (
                                Value = 100.0f,
                                Label = "Feb",
                                ValueLabel = "100",
                                Color = SKColor.Parse("#200489")
                            )
                        |]

                        let chart = new BarChart()
                        chart.Entries <- entries
                        chart
                    )

                ]
            ]
        ]